namespace CREDITProcessament.Infra.IOC

open AutoMapper.Contrib.Autofac.DependencyInjection
open Autofac
open CREDITProcessament.Data.Core.Interfaces
open CREDITProcessament.Data.Repository.Repositories
open CREDITProcessament.Domain.Core.Interfaces
open CREDITProcessament.Domain.Mappers
open CREDITProcessament.Domain.Models.RequestModels
open CREDITProcessament.Domain.Services.Services
open CREDITProcessament.Domain.Validators
open FluentValidation

type ConfigurationIOC() = class

    static member Load(containerBuilder : ContainerBuilder) =
        containerBuilder.RegisterAutoMapper(typeof<MappingProfile>.Assembly) |> ignore

        containerBuilder.RegisterType<AddUserValidator>().As<IValidator<AddUserRequestModel>>() |> ignore
        containerBuilder.RegisterType<DeleteUserValidator>().As<IValidator<DeleteUserRequestModel>>() |> ignore
        containerBuilder.RegisterType<GetUserByCPFValidator>().As<IValidator<GetUserByCPFRequestModel>>() |> ignore
        containerBuilder.RegisterType<UpdateUserValidator>().As<IValidator<UpdateUserRequestModel>>() |> ignore

        containerBuilder.RegisterType<UserRepository>().As<IUserRepository>() |> ignore
        containerBuilder.RegisterType<UserService>().As<IUserService>() |> ignore

end
