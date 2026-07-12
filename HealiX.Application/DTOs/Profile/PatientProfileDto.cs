namespace HealiX.Application.DTOs.Profile
{
    public class PatientProfileDto
    {
        public string FullName { get; set; } = string.Empty;
        public string Initials { get; set; } = string.Empty;
        public string ProfileImageUrl { get; set; } = string.Empty;
        public DateTime MemberSince { get; set; }
        public int TotalAppointments { get; set; }
        public int UploadedReports { get; set; }
        public string BloodType { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string EmergencyContact { get; set; } = string.Empty;
    }
}