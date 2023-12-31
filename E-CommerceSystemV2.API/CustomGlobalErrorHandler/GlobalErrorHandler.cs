﻿using E_CommerceSystemV2.API.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Errors.Model;
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

            ProblemDetails problems = new ProblemDetails();
          
            switch (exception)
            {
                case BadRequestException badRequestException:
                    problems = new ProblemDetails
                    {
                        Title = "Bad Request",
                        Status = StatusCodes.Status400BadRequest,
                        Detail = badRequestException.Message
                    };
                    Log.Error(exception.Message, "Bad Request Error Occurred");

                    httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                break;
 

                case NotFoundException notFoundException:
                    problems = new ProblemDetails
                    {
                        Title = "Not Found",
                        Status = StatusCodes.Status404NotFound,
                        Detail = notFoundException.Message
                    };
                    Log.Error(exception.Message, "NotFound Error Occurred");

                    httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                break;

                default:
                    problems = new ProblemDetails()
                    {
                        Title = "Request Time Out",
                        Status = StatusCodes.Status408RequestTimeout,
                        Detail = " Please try again."
                    };

                break;
            }
            await httpContext.Response.WriteAsJsonAsync(problems, cancellationToken);
            return true;
        }
    }
}
