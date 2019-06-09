using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FFTCGInventoryManager.Entities;
using FFTCGInventoryManager.Repositories;
using FFTCGInventoryManager.Services;
using FFTCGInventoryManager.DBConnectors;

namespace FFTCGInventoryManager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IInventoryRepository, DictInventoryRepository>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddSingleton<IDbConnectionProvider, MySQLConnectionProvider>();
            services.AddSingleton<ICardRepository, MySQLCardRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
