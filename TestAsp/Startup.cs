using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders.Physical;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestAsp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


          

            app.UseDefaultFiles(); // Means search for the index.html or default files in wwwroot
            app.UseStaticFiles(); // Static files are files in the wwwroot

            app.UseHttpsRedirection();
         

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                app.UseEndpoints(endpoints =>    // Route to the index.html if 404 Error and for SPA it always routes to index because SPA is single page APP.
                {
                    endpoints.MapFallbackToFile("/index.html");
                });
            });
        }

    }
}
