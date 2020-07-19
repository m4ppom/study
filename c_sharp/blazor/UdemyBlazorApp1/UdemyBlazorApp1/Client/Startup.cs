using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components;

namespace UdemyBlazorApp1.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<SingletonServices>();
            services.AddTransient<TransientServices>();
        }
        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }

    }
}
 