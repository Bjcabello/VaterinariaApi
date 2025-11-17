using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using VeterinariaApi.Abstractions.IApplication;
using VeterinariaApi.Abstractions.IRepository;
using VeterinariaApi.Abstractions.IServices;
using VeterinariaApi.Repository.User;

namespace VeterinariaApi.Repository
{
    public static class RepositoryServiceRegister
    {
        

        public static IServiceCollection AddRepositoryServices(this IServiceCollection iservices)
        {
            iservices.AddScoped<IUserRepository, UserRepository>();
            return iservices;
        }

    }
}
