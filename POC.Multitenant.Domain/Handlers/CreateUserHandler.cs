using POC.Multitenant.Domain.Commands.Requests;
using POC.Multitenant.Domain.Commands.Responses;
using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces.Handlers;
using POC.Multitenant.Domain.Interfaces.Repositories;

namespace POC.Multitenant.Domain.Handlers
{
    public class CreateUserHandler : ICreateUserHandler
    {
        private readonly IUserRepository _repository;

        public CreateUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public CreateUserResponse HandleAsync(CreateUserRequest command)
        {
            // Aplicar Fail Fast Validations

            // Cria a entidade
            var user = new User(command.Name);

            // Persiste a entidade no banco
            _repository.CreateUser(user);

            // Envia E-mail de boas-vindas
            //_emailService.Send(customer.Name, customer.Email);

            // Retorna a resposta
            return new CreateUserResponse
            {
                TenantId = user.TenantId,
                Id = user.Id,
                Name = user.Name,
            };
        }
    }
}
