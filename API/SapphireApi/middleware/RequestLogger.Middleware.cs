using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using SapphireApi;

namespace SapphireApi.Middleware {
  public class RequestLoggerMiddleware {
    private readonly RequestDelegate _next;
    public RequestLoggerMiddleware(RequestDelegate next){
      _next = next;
    }
    public async Task InvokeAsync(HttpContext context){

      Log.info("Request_Logger_Middleware", "("+ context.Request.Method.ToUpper() +") Call To => " + context.Request.Path.ToString());

      await _next(context);
    }
  }
}