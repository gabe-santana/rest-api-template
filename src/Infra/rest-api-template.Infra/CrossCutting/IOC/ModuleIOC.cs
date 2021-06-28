using Autofac;

namespace rest_api_template.Infra.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           ConfigurationIOC.Load(builder);
        }
    }
}