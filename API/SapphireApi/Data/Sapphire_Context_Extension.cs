
using System.Linq;
using Microsoft.AspNetCore.Http;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data{
  public static class Sapphire_ContextExtension{
    public static string getUID(this Sapphire_Context context){
      return context._httpContext.HttpContext.User.Claims.First(x=>x.Type==Claims.UID).Value;
    }
    public static int getCompany(this Sapphire_Context context){
      return context._httpContext.HttpContext.User.Claims.Count() == 0 ?
          -1
        :
          int.Parse(context._httpContext.HttpContext.User.Claims.First(x=>x.Type==Claims.COMPANY).Value);
    }
  }
}