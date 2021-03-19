using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Adminsitration.Setup.Objects{
  public class ObjectModelBuilder: IdentificableModelBuilder<ObjectModel> {
    public override void Configure(EntityTypeBuilder<ObjectModel> builder)
    {
      base.Configure(builder);

      builder.ToTable(Schemas.ADM + Tables.OBJECTS);

      builder
        .Property(model => model.code)
        .HasMaxLength(4)
        .IsRequired();

      builder
        .Property(model => model.description)
        .IsDescription();

      builder
        .Property(model => model.docPrefix)
        .HasMaxLength(2);

      builder
        .HasIndex(model => model.defaultSerieId)
        .HasDatabaseName("IX_OOBJ_defaultSerieId");
    }
  }
}