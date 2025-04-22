using IssueTracker.Application.Exceptions;
using System.Net;
using System.Net.Mail;
using System.Text.Json;

namespace IssueTracker.Api.Extensions
{
    public class ExceptionHandlerMiddleware
    {

        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex) 
            { 
                await ConvertException(context, ex);
            }

        }

        private async Task ConvertException(HttpContext context, Exception ex)
        {
            HttpStatusCode statusCode= HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";
            var result = string.Empty;

            switch (ex)
            {
                case ValidationException validationException:
                    statusCode = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(validationException.ValidationErrors);
                    break;
                case BadRequestException badRequestException:
                    statusCode = HttpStatusCode.BadRequest;
                    result = badRequestException.Message;
                    break;
                case NotFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    //result = notFoundException.Message;
                    break;
                case Exception:
                    statusCode = HttpStatusCode.BadRequest;
                    break;
            }
            context.Response.StatusCode = (int)statusCode;
            if(result == string.Empty)
            {
                result = JsonSerializer.Serialize(new { error = ex.Message });
            }
            await context.Response.WriteAsync(result);
        }
    }
}
