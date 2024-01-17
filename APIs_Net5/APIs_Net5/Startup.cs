using APIs_Net5.Repositories;
using Microsoft.AspNetCore.Builder;

namespace APIs_Net5
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IInMemItemsRepository, InMemItemsRepository>();
            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new() { Title = "APIs_Net5", Version = "v1" }); });
        }
    }
}
