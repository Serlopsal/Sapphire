using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.Transferences.Request {
  public class TransferRequestDetailsModelBuilder: DocumentableDetailsModelBuilder<TransferRequestDetailsModel, TransferRequestModel> {
    public override void Configure(EntityTypeBuilder<TransferRequestDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.INV + Tables.TRANSFER_REQUEST_DETAILS);
    }
  }
}