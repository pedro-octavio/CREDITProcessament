namespace CREDITProcessament.Infra.IOC

open Autofac

type ModuleIOC() = class
    inherit Module()

    override this.Load(containerBuilder : ContainerBuilder) =
        ConfigurationIOC.Load(containerBuilder) |> ignore

end
