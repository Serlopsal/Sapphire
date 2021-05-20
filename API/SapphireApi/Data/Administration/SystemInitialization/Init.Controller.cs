using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SapphireApi.Data.Adminsitration.SystemInitialization {
  [Route("api/[controller]")]
  [ApiController]
  public class InitController: ControllerBase {
    [HttpGet]
    public ActionResult<Boolean> GetWasSystemInitialized(){
      return false;
    }
  }
}