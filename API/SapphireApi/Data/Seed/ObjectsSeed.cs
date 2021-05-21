using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SapphireApi.Data.Administration.Setup.Objects;
using SapphireApi.Data.Identity;

namespace SapphireApi.Data {
  internal class ObjectSeed {
    public ObjectSeed(ModelBuilder builder) {
      var OBJ_ID = 101;
      var CREATOR_ID = "40709ea0-0908-4bea-8468-433bd706cedd";
      var UPDATED_ID = CREATOR_ID;
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
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          },
          new ObjectModel(){
            id = 1,
            code = "OADM",
            description = "Companies",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 102,
            code = "ONNM",
            description = "Series",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 110,
            code = "OCRY",
            description = "Countries",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 111,
            code = "OCST",
            description = "Cities",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 120,
            code = "OUOM",
            description = "Units Of Measure",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 121,
            code = "OUGP",
            description = "UOM Converters",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 130,
            code = "OCRN",
            description = "Currencies",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 131,
            code = "ORTT",
            description = "Currencies Rates",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 201,
            code = "OWHS",
            description = "Warehouses",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 202,
            code = "OMRC",
            description = "Manufacter",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 203,
            code = "OKOM",
            description = "Kind Of Movements",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 210,
            code = "OITB",
            description = "Item's Groups",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 211,
            code = "OITM",
            description = "Items",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 212,
            code = "OBTN",
            description = "Item's Batches",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 220,
            code = "OITL",
            description = "Batches Transactions",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 221,
            code = "OIGN",
            description = "Items Receipts",
            objType = OBJ_ID,
            docPrefix = "IR",
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 222,
            code = "OIGE",
            description = "Items Dispatches",
            objType = OBJ_ID,
            docPrefix = "ID",
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 223,
            code = "OWTQ",
            description = "Items Warehouse Transfer Request",
            objType = OBJ_ID,
            docPrefix = "TQ",
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 224,
            code = "OWTR",
            description = "Items Warehouse Transference",
            objType = OBJ_ID,
            docPrefix = "TR",
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 300,
            code = "OPLN",
            description = "Price Lists",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 310,
            code = "OCRG",
            description = "Bussiness Partners Groups",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
          }
          ,
          new ObjectModel(){
            id = 311,
            code = "OCRD",
            description = "Bussiness Partners Cards",
            objType = OBJ_ID,
            docPrefix = null,
            defaultSerieId = null,
            // Id From IdentitySeed
            createdBy = CREATOR_ID,
            updatedBy = UPDATED_ID
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