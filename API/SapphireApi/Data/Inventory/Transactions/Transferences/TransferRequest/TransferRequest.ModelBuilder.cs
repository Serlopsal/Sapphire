using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.Transferences.Request {
  public class TransferRequestModelBuilder: TransferTransactionModelBuilder<TransferRequestModel> {
    public override void Configure(EntityTypeBuilder<TransferRequestModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.TRANSFER_REQUEST, Schemas.INV);
    }
  }
}