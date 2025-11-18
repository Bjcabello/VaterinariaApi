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

        public async Task<ResultDTO<int>> Create(UserCreateRequestDto request)
        {
            ResultDTO<int> res = new ResultDTO<int>();

            try
            {
                using(var cn = new SqlConnection(_connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@p_id", request.id);
                    parameters.Add("@p_username", request.username);
                    parameters.Add("@p_password", request.password);
                    parameters.Add("@p_role_id", request.role_id);

                    using (var lector = await cn.ExecuteReaderAsync("SP_CREATE_USER", parameters, commandType:System.Data.CommandType.StoredProcedure))
                    {
                        while(lector.Read())
                        {
                            res.Item = Convert.ToInt32(lector["id"].ToString());
                            res.IsSuccess = Convert.ToInt32(lector["id"].ToString()) > 0 ? true: false;
                            res.Message = Convert.ToInt32(lector["id"].ToString()) > 0 ? "Informacion guardada correctamente" : "Informacion no se pudo guardar";
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.MessageException = ex.Message;

            }
            return res;
        }

        public async Task<ResultDTO<int>> Delete(DeleteDto request)
        {
            ResultDTO<int> res = new ResultDTO<int>();
            try
            {
                using (var cn = new SqlConnection(_connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@p_id", request.id);
                    using (var lector =  cn.ExecuteReaderAsync("SP_DELETE_USER", parameters, commandType: System.Data.CommandType.StoredProcedure))
                    {
                        while (lector.Result.Read())
                        {
                            res.Item = Convert.ToInt32(lector.Result["id"].ToString());
                            res.IsSuccess = Convert.ToInt32(lector.Result["id"].ToString()) > 0 ? true : false;
                            res.Message = Convert.ToInt32(lector.Result["id"].ToString()) > 0 ? "Informacion eliminada correctamente" : "Informacion no se pudo eliminar";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;  
                res.MessageException = ex.Message;
            }
            return res;
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
