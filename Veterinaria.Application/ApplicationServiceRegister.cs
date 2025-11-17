using Microsoft.Extensions.DependencyInjection;
using Veterinaria.Application.User;
using VeterinariaApi.Abstractions.IApplication;
using VeterinariaApi.Abstractions.IServices;

namespace Veterinaria.Application
{
    public static class ApplicationServiceRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection iservices)
        {
            iservices.AddScoped<IUserApplication, UserApplication>();
            return iservices;
        }
    }
}
