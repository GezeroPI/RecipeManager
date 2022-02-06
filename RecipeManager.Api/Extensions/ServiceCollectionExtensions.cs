using FluentValidation;
using Microsoft.EntityFrameworkCore;
using RecipeManager.Api.DTOs;
using RecipeManager.Api.Services;
using RecipeManager.Domain.Interfaces;
using RecipeManager.Infrastructure;
using RecipeManager.Infrastructure.Context;
using RecipeManager.Infrastructure.Repositories;

namespace RecipeManager.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>))
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IRecipeRepository, RecipeRepository>()
                ;
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services
            , IConfiguration configuration)
        {
            return services.AddDbContext<RecipeContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("ConStr")));
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services
           )
        {
            return services
                .AddScoped<UserService>()
                .AddScoped<RecipeService>()
                .AddScoped<IngredientService>();
        }

    }
}
