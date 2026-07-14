using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealiX.Application.Interfaces;
using HealiX.Application.DTOs.Dashboard;
using HealiX.Infrastructure.Data;

namespace HealiX.Infrastructure.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly ApplicationDbContext _context;

        public DashboardService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DashboardStatsDto> GetStatsAsync()
        {
            return new DashboardStatsDto
            {
                TotalDoctors = await _context.Set<HealiX.Domain.Entities.DoctorProfile>().CountAsync(),
                TotalClinics = await _context.Set<HealiX.Domain.Entities.Clinic>().CountAsync(),
                TotalAppointments = await _context.Set<HealiX.Domain.Entities.Appointment>().CountAsync(),
                TotalPatients = await _context.Set<HealiX.Domain.Entities.User>().CountAsync()
            };
        }

        public async Task<IEnumerable<UpcomingAppointmentDto>> GetUpcomingAppointmentsAsync(int count)
        {
            return await _context.Set<HealiX.Domain.Entities.Appointment>()
                .Take(count)
                .Select(a => new UpcomingAppointmentDto
                {
                    Id = a.Id,
                    Status = a.Status
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<RecentReportDto>> GetRecentReportsAsync(int count)
        {
            return await _context.Set<HealiX.Domain.Entities.MedicalReport>()
                .Take(count)
                .Select(r => new RecentReportDto
                {
                    Id = r.Id,
                    DiagnosisSummary = r.Diagnosis
                })
                .ToListAsync();
        }
    }
}