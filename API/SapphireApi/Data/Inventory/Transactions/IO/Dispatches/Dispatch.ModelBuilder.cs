using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Dispatches {
  public class DispatchModelBuilder: IOTransactionModelBuilder<DispatchModel> {
    public override void Configure(EntityTypeBuilder<DispatchModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS_DISPATCHES, Schemas.INV);
    }
  }
}