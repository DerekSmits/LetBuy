using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Middleware
{
    public  class Check
    {
        private readonly RequestDelegate _next;
        public Check(RequestDelegate next) {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context) {
            var ton = context.Request.Query["id"];
            if (ton != "674")
            {
                await _next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Попал");
            }
        }
    }
    public static class CheckUse
    {
        public static IApplicationBuilder UseCheck(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Check>();
        }
    }
}
