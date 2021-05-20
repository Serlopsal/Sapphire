using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SapphireApi.Data.Administration.Setup.Objects;
using SapphireApi.Data.Identity;

namespace SapphireApi.Data {
  internal class ObjectSeed {
    public ObjectSeed(ModelBuilder builder) {
      var OBJ_ID = 1;
      builder
        .Entity<ObjectModel>()
        .HasData(
          new ObjectModel(){
            id = OBJ_ID,
            code = "OOBJ",
            description = "Objects",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = "40709ea0-0908-4bea-8468-433bd706cedd",
            updatedBy = "40709ea0-0908-4bea-8468-433bd706cedd"
          }
          ,
          new ObjectModel(){
            id = 2,
            code = "ONNM",
            description = "Series",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = "40709ea0-0908-4bea-8468-433bd706cedd",
            updatedBy = "40709ea0-0908-4bea-8468-433bd706cedd"
          }
          // [ TEMPLATE ]
          // ,
          // new ObjectModel(){
          //   id = ,
          //   code = "",
          //   description = "",
          //   objType = OBJ_ID,
          //   docPrefix = null,
          //   defaultSerieId = null,
          //   // Id From IdentitySeed
          //   createdBy = "40709ea0-0908-4bea-8468-433bd706cedd",
          //   updatedBy = "40709ea0-0908-4bea-8468-433bd706cedd"
          // }
        );  
    }
  }
}