using Microsoft.Extensions.DependencyInjection;
using VeterinariaApi.Abstractions.IServices;
using VeterinariaApi.Services.User;

namespace VeterinariaApi.Services
{
    public static class ServicesServiceRegister
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection iservices)
        {
            iservices.AddScoped<IUserService, UserService>();
            return iservices;
        }
    }
}
