using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SapphireApi.Data.Administration.SystemInitialization {
  [Route("api/[controller]")]
  [ApiController]
  public class InitController: ControllerBase {
    [HttpGet]
    public ActionResult<Boolean> GetWasSystemInitialized(){
      // Only For testing purposes
      // TODO: Build the production logic
      return false;
    }
  }
}