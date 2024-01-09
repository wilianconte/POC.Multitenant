using POC.Multitenant.Domain.Interfaces.Services;
using POC.Multitenant.Domain.Services;

namespace POC.Multitenant.API.Extensions;

public static class ScopedServicesExtensions
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
    }
}