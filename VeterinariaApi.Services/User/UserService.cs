using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaApi.Abstractions.IRepository;
using VeterinariaApi.Abstractions.IServices;
using VeterinariaApi.DTOs.Auth;
using VeterinariaApi.DTOs.Common;
using VeterinariaApi.DTOs.User;

namespace VeterinariaApi.Services.User
{
    public class UserService: IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<ResultDTO<int>> Create(UserCreateRequestDto request)
        {
            return await userRepository.Create(request);
        }

        public async Task<ResultDTO<int>> Delete(DeleteDto request)
        {
            return await userRepository.Delete(request);
        }

        public async Task<ResultDTO<UserListResponseDTO>>GetAll()
        {
            return await userRepository.GetAll();
        }

        public async Task<AuthResponseDto> Login(LoginRequestDto request)
        {
            return await userRepository.Login(request);
        }
    }
}
