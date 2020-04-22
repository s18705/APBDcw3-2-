using APBDcw3_2_.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace APBDcw3_2_
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
            services.AddTransient<IDbService, MockDbService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }



            //app.UseHttpsRedirection(); //jesli na samym poczatku bedzie rzadanie niezabezpieczone (nie HTTPS) to go nie przepusci  


            //Doklejal do odpowiedzi naglowek http
            app.Use(async (context, c) =>
            {
                context.Response.Headers.Add("Secrect", "1234");
                await c.Invoke(); //przepuszcza rz¹danie dalej
            });
            app.UseMiddleware<CustomMiddleware>();  //nasz w³asny 

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
