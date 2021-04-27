using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Marketing.Pricing.PriceList {
  public partial class PriceListDetailModelBuilder: IdentificableModelBuilder<PriceListDetailModel> {
    public override void Configure(EntityTypeBuilder<PriceListDetailModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.MKT + Tables.PRICE_LIST_DETAILS);

      builder
        .Property(model => model.itemCode)
        .IsCode();
    }
  }
}