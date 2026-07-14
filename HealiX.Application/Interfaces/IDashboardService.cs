using System.Collections.Generic;
using System.Threading.Tasks;
using HealiX.Application.DTOs.Dashboard;

namespace HealiX.Application.Interfaces
{
    public interface IDashboardService
    {
        Task<DashboardStatsDto> GetStatsAsync();
        Task<IEnumerable<UpcomingAppointmentDto>> GetUpcomingAppointmentsAsync(int count);
        Task<IEnumerable<RecentReportDto>> GetRecentReportsAsync(int count);
    }
}