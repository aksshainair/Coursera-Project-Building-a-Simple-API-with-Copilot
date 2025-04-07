// filepath: Middleware/LoggingMiddleware.cs
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log the incoming request
            var method = context.Request.Method;
            var path = context.Request.Path;
            Console.WriteLine($"Incoming Request: {method} {path}");

            // Call the next middleware in the pipeline
            await _next(context);

            // Log the outgoing response
            var statusCode = context.Response.StatusCode;
            Console.WriteLine($"Outgoing Response: {statusCode}");
        }
    }
}