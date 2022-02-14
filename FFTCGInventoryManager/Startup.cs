using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FFTCGInventoryManager.Services;
using FFTCGInventoryManager.DBConnectors;
using FFTCGInventoryManager.Repositories.InventoryRepository;
using FFTCGInventoryManager.Repositories.CardRepository;
using FFTCGInventoryManager.Repositories.UserRepository;
using System;

namespace FFTCGInventoryManager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private readonly string _frontEndURL = Environment.GetEnvironmentVariable("FRONT_END_URL");
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public IConfiguration Configuration { get; }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
                {
                    options.AddPolicy(MyAllowSpecificOrigins, builder =>
                    {
                        builder.WithOrigins(_frontEndURL);
                    });
                });

            services.AddMvc();
            services.AddSingleton<IInventoryRepository, MySQLInventoryRepository>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddSingleton<IDbConnectionProvider, MySQLConnectionProvider>();
            services.AddSingleton<ICardRepository, MySQLCardRepository>();
            services.AddSingleton<ICardService, CardService>();
            services.AddSingleton<IUserRepository, MySQLUserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(MyAllowSpecificOrigins);
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
