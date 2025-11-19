using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaApi.DTOs.Auth;
using VeterinariaApi.DTOs.Common;
using VeterinariaApi.DTOs.User;

namespace VeterinariaApi.Abstractions.IApplication
{
    public interface IUserApplication
    {
        public Task<ResultDTO<UserListResponseDTO>> GetAll();
        public Task<ResultDTO<int>> Create(UserCreateRequestDto request);
        public Task<ResultDTO<int>> Delete(DeleteDto request);
        public Task<AuthResponseDto> Login(LoginRequestDto request);
    }

}

