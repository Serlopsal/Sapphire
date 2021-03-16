
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.ItemsGroup {
  public partial class ItemsGroupModelBuilder : IdentificableModelBuilder<ItemsGroupModel> {
    public override void Configure(EntityTypeBuilder<ItemsGroupModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS_GROUP, Schemas.INV);

      builder
        .Property(model => model.itmsGrpNam)
        .IsName();
    }
  }
}