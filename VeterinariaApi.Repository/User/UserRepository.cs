

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using VeterinariaApi.Abstractions.IRepository;
using VeterinariaApi.DTOs.Common;
using VeterinariaApi.DTOs.User;

namespace VeterinariaApi.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private string _connectionString = "";
        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Connection");
        }
        public async Task<ResultDTO<UserListResponseDTO>> GetAll()
        {
            await Task.CompletedTask;  

            ResultDTO<UserListResponseDTO> res = new ResultDTO<UserListResponseDTO>
            List<UserListResponseDTO> list = new List<UserListResponseDTO>();
            try
            {
                using (var cn = new SqlConnection(_connectionString)) { }
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.MessageException = ex.Message;
            }
            



        }
    }
}
