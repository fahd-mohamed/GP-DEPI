using System.Text;
using HealiX.Domain.Entities;
using HealiX.Application.DTOs.Auth;
using System.Security.Cryptography;
using HealiX.Application.Interfaces.Auth;
using HealiX.Application.Interfaces.Repositories;
namespace HealiX.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepo;
        private readonly ITokenService _tokenService;
        public AuthService(IUserRepository userRepo, ITokenService tokenService)
        {
            _userRepo = userRepo;
            _tokenService = tokenService;
        }
        public async Task<AuthResponseDto> RegisterAsync(RegisterDTO dto)
        {
            var existingUser = await _userRepo.GetByEmailAsync(dto.Email);
            if (existingUser != null)
                throw new Exception("Email already exists");

            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = HashPassword(dto.Password),
                RoleId = 1 //Patient
            };

            await _userRepo.AddAsync(user);

            return new AuthResponseDto
            {
                Email = user.Email,
                RoleId = user.RoleId,
                Token = _tokenService.GenerateToken(user)
            };
        }
        public async Task<AuthResponseDto> LoginAsync(LoginDTO dto)
        {
            var user = await _userRepo.GetByEmailAsync(dto.Email);

            if (user == null || user.Password != HashPassword(dto.Password))
                throw new Exception("Invalid credentials");

            return new AuthResponseDto
            {
                Email = user.Email,
                RoleId = user.RoleId,
                Token = _tokenService.GenerateToken(user)
            };
        }
        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}