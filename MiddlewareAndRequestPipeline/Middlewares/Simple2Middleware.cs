using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareAndRequestPipeline.middleware
{
    public class Simple2Middleware
    {
        private readonly RequestDelegate _next;

        public Simple2Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("<div> Hello World from the Simple2 Middleware </div>");
            await _next(context);
            await context.Response.WriteAsync("<div> Returning from the Simple2 Middleware </div>");
        }
    }
}