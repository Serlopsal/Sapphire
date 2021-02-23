using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.IO.Receipts {
  public class ReceiptDetailsModelBuilder: DocumentableDetailsModelBuilder<ReceiptDetailsModel, ReceiptModel> {
    public override void Configure(EntityTypeBuilder<ReceiptDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.ITEMS_RECEPT_DETAILS, Schemas.INV);
    }
  }
}