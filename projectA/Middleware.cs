using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Entities.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace projectA
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;

        IRatingBL _IratingBL;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IRatingBL Iratingbl)
        {
            
            _IratingBL = Iratingbl;
            Rating rating = new Rating();
            rating.Host = httpContext.Request.Host.ToString();
            rating.Method =httpContext.Request.Method;
            rating.Path =httpContext.Request.Path;
            rating.UserAgent =httpContext.Request.Headers["User-Agent"];
            rating.Referer = httpContext.Request.Headers["Referer"];
            rating.RecordDate =DateTime.Now;

              _IratingBL.addToCntx(rating);

            
             await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
