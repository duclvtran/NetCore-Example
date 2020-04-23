using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MiddlewareAndRequestPipeline.Extensions;
using MiddlewareAndRequestPipeline.middleware;

namespace MiddlewareAndRequestPipeline
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Inline middleware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<div> Hello World from the Middleware 1 </div>");
                await next.Invoke();
                await context.Response.WriteAsync("<div> Returning from the Middleware 1 </div>");
            });

            //Inline middleware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<div> Hello World from the Middleware 2 </div>");
                await next.Invoke();
                await context.Response.WriteAsync("<div> Returning from the Middleware 2 </div>");
            });

            //Custom middleware
            app.UseMiddleware<Simple1Middleware>();

            //Extensions middleware
            app.UseSimpleMiddleware();

            //Inline middleware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<div> Hello World from the Middleware 3 </div>");
                await next.Invoke();
                await context.Response.WriteAsync("<div> Returning from the Middleware 3 </div>");
            });

            //Inline middleware
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<div> Hello World from the Middleware 4 </div>");
            });
        }
    }
}