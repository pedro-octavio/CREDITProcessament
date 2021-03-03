namespace CREDITProcessament.Infra.IOC

open Autofac

open CREDITProcessament.Data.Repository.Repositories
open CREDITProcessament.Data.Core.Interfaces

type ConfigurationIOC() = class

    static member Load(containerBuilder : ContainerBuilder) =
        containerBuilder.RegisterType<UserRepository>().As<IUserRepository>()

end
