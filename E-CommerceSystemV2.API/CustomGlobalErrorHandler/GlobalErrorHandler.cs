
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Serilog;
namespace E_CommerceSystemV2.API.CustomGlobalErrorHandler
{
    public class GlobalErrorHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalErrorHandler> _logger;
        public GlobalErrorHandler(ILogger<GlobalErrorHandler> logger  )
        {
            _logger = logger;
        }
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(exception, "Exception Occurred :{Message}", exception.Message);
            Log.Error(exception.Message,"Internal Server Error Occurred");

            ProblemDetails problems = new()
            {
                Title = "Server Error",
                Status = StatusCodes.Status500InternalServerError
            };

            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            await httpContext.Response.WriteAsJsonAsync(problems , cancellationToken);
            return true;
        }
    }
}
