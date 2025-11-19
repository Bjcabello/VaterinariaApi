using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaApi.DTOs.Auth;
using VeterinariaApi.DTOs.Common;
using VeterinariaApi.DTOs.User;

namespace VeterinariaApi.Abstractions.IRepository
{
    public interface IUserRepository
    {
        public Task<ResultDTO<UserListResponseDTO>> GetAll();
        public Task<ResultDTO<int>> Create(UserCreateRequestDto request);
        public Task<ResultDTO<int>> Delete(DeleteDto request);
        public Task<TokenResponseDto> GenerateToken(UserDetailResponseDto request);
        public Task<UserDetailResponseDto> GetUserByUsername(string username);
        public Task<UserDetailResponseDto> ValidateUser(LoginRequestDto request);
        public Task<AuthResponseDto> Login(LoginRequestDto request);
    }

}
