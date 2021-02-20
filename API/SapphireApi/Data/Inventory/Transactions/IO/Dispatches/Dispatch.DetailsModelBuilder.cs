using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Dispatches {
  public class DispatchDetailsModelBuilder: IOTransactionDetailsModelBuilder<DispatchDetailsModel, DispatchModel> {
    public override void Configure(EntityTypeBuilder<DispatchDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS_DISPATCH_DETAILS, Schemas.INV);
    }
  }
}