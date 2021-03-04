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

        containerBuilder.RegisterType<AddProcessamentValidator>().As<IValidator<AddProcessamentRequestModel>>() |> ignore
        containerBuilder.RegisterType<DeleteProcessamentValidator>().As<IValidator<DeleteProcessamentRequestModel>>() |> ignore
        containerBuilder.RegisterType<DeleteRangeProcessamentValidator>().As<IValidator<DeleteRangeProcessamentRequestModel>>() |> ignore
        containerBuilder.RegisterType<GetAllProcessamentsByCreateDateValidator>().As<IValidator<GetAllProcessamentsByCreateDateRequestModel>>() |> ignore
        containerBuilder.RegisterType<GetAllProcessamentsByProcessedValidator>().As<IValidator<GetAllProcessamentsByProcessedRequestModel>>() |> ignore
        containerBuilder.RegisterType<GetProcessamentByUserCPFValidator>().As<IValidator<GetProcessamentByUserCPFRequestModel>>() |> ignore
        containerBuilder.RegisterType<UpdateProcessamentValidator>().As<IValidator<UpdateProcessamentRequestModel>>() |> ignore

        containerBuilder.RegisterType<UserRepository>().As<IUserRepository>() |> ignore
        containerBuilder.RegisterType<ProcessamentRepository>().As<IProcessamentRepository>() |> ignore

        containerBuilder.RegisterType<UserService>().As<IUserService>() |> ignore
        containerBuilder.RegisterType<ProcessamentService>().As<IProcessamentService>() |> ignore

end
