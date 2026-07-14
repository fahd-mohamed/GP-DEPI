using HealiX.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealiX.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<DoctorProfile> DoctorProfiles { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalReport> MedicalReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. تحديد المفتاح المركب لجدول صلاحيات الأدوار
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            // 2. تحديد المفتاح المركب لجدول الأطباء والعيادات
            modelBuilder.Entity<DoctorClinic>()
                .HasKey(dc => new { dc.DoctorId, dc.ClinicId });

            // 3. تحديد المفتاح المركب لجدول الأطباء والتخصصات
            modelBuilder.Entity<DoctorSpecialty>()
                .HasKey(ds => new { ds.DoctorId, ds.SpecialtyId });

            // 4. تحديد المفتاح المركب لجدول المشاركين في المحادثة
            modelBuilder.Entity<ConversationParticipant>()
                .HasKey(cp => new { cp.ConversationId, cp.UserId });

            
            // 5. تحديد المفتاح الأساسي لملف الطبيب وضبط العلاقات
            modelBuilder.Entity<DoctorProfile>(entity =>
            {
                // تحديد المفتاح الأساسي
                entity.HasKey(dp => dp.DoctorId);

                // حل التحذير الأول: تظبيط العلاقة بين الطبيب والمستخدم
                entity.HasOne(dp => dp.Doctor)
                      .WithOne()
                      .HasForeignKey<DoctorProfile>(dp => dp.DoctorId);

                // حل التحذير التاني: تحديد شكل الرقم العشري للفلوس (18 رقم منهم 2 بعد العلامة)
                entity.Property(dp => dp.ConsultationFee)
                      .HasColumnType("decimal(18,2)");
            });
            // 6. حل مشكلة الحذف المتعدد (Cascade Delete) وتحديد المفتاح الأجنبي للتقارير الطبية
            modelBuilder.Entity<MedicalReport>()
                .HasOne(m => m.Doctor)
                .WithMany()
                .HasForeignKey(m => m.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}