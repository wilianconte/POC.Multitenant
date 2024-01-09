using POC.Multitenant.Data.Repositories;
using POC.Multitenant.Domain.Interfaces.Repositories;

namespace POC.Multitenant.API.Extensions;

public static class ScopedRepositoriesExtensions
{
    public static void AddCustomRepositories(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
    }
}