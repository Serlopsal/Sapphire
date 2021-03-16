using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Receipts {
  public class ReceiptBatchDetailsModelBuilder: DocumentableBatchDetailModelBuilder<ReceiptBatchDetailsModel, ReceiptDetailsModel, ReceiptModel> {
    public override void Configure(EntityTypeBuilder<ReceiptBatchDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS_RECEIPT_BATCH_DETAILS, Schemas.INV);
    }
  }
}