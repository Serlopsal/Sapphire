
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace SapphireApi.Data{
  public static class Sapphire_ContextExtension{
    public static string getUID(this Sapphire_Context context){
      return context._httpContext.HttpContext.User.Claims.First(x=>x.Type=="uid").Value;
    }
  }
}