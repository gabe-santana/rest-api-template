using Autofac;
using rest_api_template.Application;
using rest_api_template.Application.DTO;
using rest_api_template.Application.Interfaces;
using rest_api_template.Application.Mappers.Interfaces;
using rest_api_template.Application.Mappers.Mapper;
using rest_api_template.Domain.Core.Interfaces.Repositories;
using rest_api_template.Domain.Core.Interfaces.Services;
using rest_api_template.Domain.Entities;
using rest_api_template.Domain.Services.Services;
using rest_api_template.Infra.Data.Repositories;

namespace rest_api_template.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerServiceApplication>().As<ICustomerServiceApplication>();
            builder.RegisterType<ProductServiceApplication>().As<IProductServiceApplication>();
        
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<ProductRepository>().As<ICustomerRepository>();
        
            builder.RegisterType<CustomerMapper>().As<IEntityMapper<Customer, CustomerDTO>>();
            builder.RegisterType<ProductMapper>().As<IEntityMapper<Product, ProductDTO>>();
        }
    }
}