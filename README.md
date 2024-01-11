
# POC.Multitenant

Este projeto tem o objetivo de ser um modelo de implementação de api multi-tenant

A implementação dessa api segue a abordagem de compartilamento de banco de dados, onde o tenant 

## Comandos úteis do entity framework

Rodar a partir do projeto "POC.Multitenant.API"

#### Atualiza a versão do entity framework
dotnet tool update --global dotnet-ef --version 8.0.1

#### Cria uma migration

dotnet ef migrations add InitialCreate --project ..\POC.Multitenant.Data

#### Aplica as atualizações das migrations no banco de dados
dotnet ef database update --project ..\POC.Multitenant.Data

# Referencias

#### Implementação multi-tenant
- https://www.milanjovanovic.tech/blog/multi-tenant-applications-with-ef-core
- https://aspnano.com/build-multi-tenant-application-core-asp-net-7/

#### ASP.NET Core, CQRS e Mediator
- https://balta.io/blog/aspnet-core-cqrs-mediator