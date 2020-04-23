using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace MVCCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                //Routes
                //routes.MapRoute("default", "{admin}/{controller=Home}/{action=Index}");
                //routes.MapRoute("default", "{controller=Home}/{action=Index}/{Id?}");
                //routes.MapRoute("default", "{controller=Home}/{action=Index}");

                //Route Constraints
                //routes.MapRoute("default", "{controller=Home}/{action=Index}/{Id:int?}");
                routes.MapRoute("default", "{controller}/{action}/{id?}",
                     new { controller = "Home", action = "Index" },
                     new { id = new IntRouteConstraint() });

                routes.MapRoute("postbyid",
                            "post/{id:int}",
                            new { controller = "RouteConstraints", action = "PostById" },
                                constraints: new
                                {
                                    id = new CompositeRouteConstraint(
                                            new IRouteConstraint[]
                                            {
                                                new AlphaRouteConstraint(),
                                                new MinLengthRouteConstraint(6)
                                            })
                                });

                routes.MapRoute("postbyname",
                        "post/{id:alpha:minlength(3)?}",
                        new { controller = "RouteConstraints", action = "PostByName" });
                //new { id = new AlphaRouteConstraint() });

                routes.MapRoute("getyear",
                           "year/{year:regex(^\\d{{4}}$)}",
                           new { controller = "RouteConstraints", action = "GetYear" });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}