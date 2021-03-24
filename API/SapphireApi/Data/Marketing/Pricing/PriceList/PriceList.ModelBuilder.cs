using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Marketing.Pricing.PriceList {
  public partial class PriceListModelBuilder: IdentificableModelBuilder<PriceListModel> {
    public override void Configure(EntityTypeBuilder<PriceListModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.MKT + Tables.PRICE_LIST);

      builder
        .Property(model => model.id)
        .HasColumnName("listId");

      builder
        .Property(model => model.listName)
        .IsName();

      builder
        .Property(model => model.curCode)
        .IsShortCode();

      builder
        .Property(model => model.isLocked)
        .IsFalsy();
    }
  }
}