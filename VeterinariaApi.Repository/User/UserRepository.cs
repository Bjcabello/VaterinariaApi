using Dapper;
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

            ResultDTO<UserListResponseDTO> res = new ResultDTO<UserListResponseDTO>();
            List<UserListResponseDTO> list = new List<UserListResponseDTO>();
            try
            {
                using (var cn = new SqlConnection(_connectionString))
                {
                    list = (List<UserListResponseDTO>)await cn.QueryAsync<UserListResponseDTO>("SP_LIST_USERS", null, commandType: System.Data.CommandType.StoredProcedure);
                }
                res.IsSuccess = list.Count > 0 ? true : false;
                res.Message = list.Count > 0 ? "Informacion encontrada" : "No se encontro informacion";
                res.Data = list.ToList();
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.MessageException = ex.Message;
            }
            return res;
        }
    }
}
