using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Receipts {
  public class ReceiptBatchDetailsModelBuilder: DocumentableBatchDetailsModelBuilder<ReceiptBatchDetailsModel, ReceiptDetailsModel, ReceiptModel> {
    public override void Configure(EntityTypeBuilder<ReceiptBatchDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.INV + Tables.ITEMS_RECEIPT_BATCH_DETAILS);
    }
  }
}