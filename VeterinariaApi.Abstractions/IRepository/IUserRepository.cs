using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaApi.DTOs.Common;
using VeterinariaApi.DTOs.User;

namespace VeterinariaApi.Abstractions.IRepository
{
    public interface IUserRepository
    {
        public Task<ResultDTO<UserListResponseDTO>> GetAll();
        public Task<ResultDTO<int>> Create(UserCreateRequestDto request);
    }
}
