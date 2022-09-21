using CD.App.Extensions;
using CD.Business.Interfaces;
using CD.Data.Context;
using CD.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace CD.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services) 
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            return services; 
        } 
    }
}
