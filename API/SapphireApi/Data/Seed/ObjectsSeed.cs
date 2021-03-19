using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SapphireApi.Data.Adminsitration.Setup.Objects;
using SapphireApi.Data.Identity;

namespace SapphireApi.Data {
  internal class ObjectSeed {
    public ObjectSeed(ModelBuilder builder) {
      // builder
      //   .Entity<ObjectModel>()
      //   .HasData(
      //     new ObjectModel(){
      //       code = "1",
      //       description = "Sapphire Objects",
      //       docPrefix = null,
      //       defaultSerieId = null
      //     }
      //     ,
      //     new ObjectModel(){
      //       code = "1.1",
      //       description = "Series",
      //       docPrefix = null,
      //       defaultSerieId = null
      //     }
      //   );  
    }
  }
}