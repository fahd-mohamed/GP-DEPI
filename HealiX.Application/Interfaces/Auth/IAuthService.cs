using HealiX.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealiX.Application.DTOs;
namespace HealiX.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDto> RegisterAsync(RegisterDTO dto);
        Task<AuthResponseDto> LoginAsync(LoginDTO dto);

    }
}
