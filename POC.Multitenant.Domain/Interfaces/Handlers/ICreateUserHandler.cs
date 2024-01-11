using POC.Multitenant.Domain.Commands.Requests;
using POC.Multitenant.Domain.Commands.Responses;

namespace POC.Multitenant.Domain.Interfaces.Handlers
{
    public interface ICreateUserHandler
    {
        CreateUserResponse HandleAsync(CreateUserRequest command);
    }
}
