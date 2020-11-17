using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace projectA
{

    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExeptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExeptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExeptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseExeptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExeptionMiddleware>();
        }
    }


}
