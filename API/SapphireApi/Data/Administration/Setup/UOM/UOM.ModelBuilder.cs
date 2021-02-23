using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.Setup.UOM {
  public class UOMModelBuilder : AuditableModelBuilder<UOMModel> {
    public override void Configure(EntityTypeBuilder<UOMModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.UOM, Schemas.ADM);

      builder
        .Property(model => model.name)
        .IsName();
    }
  }
}