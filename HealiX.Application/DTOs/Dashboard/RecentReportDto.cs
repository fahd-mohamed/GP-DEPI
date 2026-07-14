using System;

namespace HealiX.Application.DTOs.Dashboard
{
    public class RecentReportDto
    {
        public int Id { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string DoctorName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string DiagnosisSummary { get; set; } = string.Empty;
    }
}