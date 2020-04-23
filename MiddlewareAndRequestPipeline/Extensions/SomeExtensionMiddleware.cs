using Microsoft.AspNetCore.Builder;
using MiddlewareAndRequestPipeline.middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareAndRequestPipeline.Extensions
{
    public static class SomeExtensionMiddleware
    {
        public static IApplicationBuilder UseSimpleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Simple2Middleware>();
        }
    }
}