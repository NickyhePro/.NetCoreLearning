using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguringApps.Infrastructure
{
    //Middleware is used to form the request pipeline
    public class ContentMiddleware
    {
        private RequestDelegate requestDelegate;
        private UptimeService uptime;

        public ContentMiddleware(RequestDelegate dg, UptimeService up)
        {
            requestDelegate = dg;
            uptime = up;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpContext.Response.WriteAsync(
                    "This is from the content middleware " +
                    $"(uptime: {uptime.Uptime}ms)", Encoding.UTF8);
            }
            else
            {
                await requestDelegate.Invoke(httpContext);
            }
        }
    }
}
