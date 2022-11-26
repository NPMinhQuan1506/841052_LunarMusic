using ApplicationTier.Domain.Interfaces.Services;
using ApplicationTier.Domain.Interfaces;
using ApplicationTier.Domain.Models;
using ApplicationTier.Infrastructure;
using ApplicationTier.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationTier.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add needed instances for database
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            // Configure DbContext with Scoped lifetime   
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(AppSettings.ConnectionString,
                    sqlOptions => sqlOptions.CommandTimeout(120));
                options.UseLazyLoadingProxies();
            }
            );

            services.AddScoped<Func<ApplicationContext>>((provider) => () => provider.GetService<ApplicationContext>());
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        /// <summary>
        /// Add instances of in-use services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<IWorkService, WorkService>()
                           .AddScoped<ICustomerPlaylistService, CustomerPlaylistService>()
                           .AddScoped<IParameterService, ParameterService>()
                           .AddScoped<ICustomerService, CustomerService>()
                           .AddScoped<ICustomerGroupService, CustomerGroupService>()
                           .AddScoped<ICustomerUserService, CustomerUserService>()
                           .AddScoped<ISongService, SongService>()
                           .AddScoped<IUserService, UserService>()
                           .AddScoped<IAuthorService, AuthorService>()
                           .AddScoped<IEmployeeService, EmployeeService>()
                           .AddScoped<ISongGroupService, SongGroupService>()
                           .AddScoped<ISPFavouriteMusicGenService, spFavouriteMusicGenService>()
                           .AddScoped<ISPFavouriteMusicDetailService, spFavouriteMusicDetailService>()
                           .AddScoped<ISingerService, SingerService>()
                           .AddScoped<IMusicGenreService, MusicGenreService>();
        }

        /// <summary>
        /// Add CORS policy to allow external accesses
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCORS(this IServiceCollection services)
        {
            return // CORS
                services.AddCors(options =>
                {
                    options.AddPolicy("MyCorsPolicy",
                        builder =>
                        {
                            builder.WithOrigins(AppSettings.CORS)
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                .AllowCredentials();
                        });
                });
        }
    }
}

