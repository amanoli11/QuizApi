using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using QuizApi.Exceptions;

namespace QuizApi.CustomMiddlewares
{
    public class GlobalErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Call the next delegate/middleware in the pipeline.
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode status;
            var stackTrace = string.Empty;
            string message;

            switch (exception)
            {
                case UnauthorizedUserException:
                    message = exception.Message;
                    status = HttpStatusCode.NotFound;
                    break;
                case DataNotFoundException:
                    message = exception.Message;
                    status = HttpStatusCode.NotFound;
                    break;
                default:
                    message = exception.Message; // "Something went wrong. Please contact the service team.";
                    status = HttpStatusCode.InternalServerError;
                    break;
            }

            var exceptionResult = JsonSerializer.Serialize(new { error = message, responseType = 1 });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;

            return context.Response.WriteAsync(exceptionResult);
        }
    }
}