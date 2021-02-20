using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Receipts {
  public class ReceiptModelBuilder: IOTransactionModelBuilder<ReceiptModel> {
    public override void Configure(EntityTypeBuilder<ReceiptModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS_RECEPTS, Schemas.INV);
    }
  }
}