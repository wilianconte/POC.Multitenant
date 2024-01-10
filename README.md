dotnet tool update --global dotnet-ef --version 8.0.1

#Rodar a partir do projeto POC.Multitenant.API
dotnet ef migrations add InitialCreate --project ..\POC.Multitenant.Data

dotnet ef database update --project ..\POC.Multitenant.Data

#Referencias
https://www.milanjovanovic.tech/blog/multi-tenant-applications-with-ef-core
https://aspnano.com/build-multi-tenant-application-core-asp-net-7/
