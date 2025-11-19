using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaApi.Abstractions.IApplication;
using VeterinariaApi.Abstractions.IServices;
using VeterinariaApi.DTOs.Auth;
using VeterinariaApi.DTOs.Common;
using VeterinariaApi.DTOs.User;

namespace Veterinaria.Application.User
{
    public class UserApplication : IUserApplication
    {
        private IUserService _useService;


        public UserApplication(IUserService userService)
        {
            _useService = userService;
        }

        public async Task<ResultDTO<int>> Create(UserCreateRequestDto request)
        {
            return await _useService.Create(request);
        }

        public async Task<ResultDTO<int>> Delete(DeleteDto request)
        {
            return await _useService.Delete(request);
        }

        public async Task<ResultDTO<UserListResponseDTO>> GetAll()
        {
            return await _useService.GetAll();
        }

        public async Task<AuthResponseDto> Login(LoginRequestDto request)
        {
            return await _useService.Login(request);
        }
    }
}
