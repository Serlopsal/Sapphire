using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Models;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.Transferences.Documents {
  public class TransferenceDetailsModelBuilder: DocumentableDetailsModelBuilder<TransferenceDetailsModel, TransferenceModel> {
    public override void Configure(EntityTypeBuilder<TransferenceDetailsModel> builder) {
      base.Configure(builder);

      builder.ToTable(Tables.TRANSFERENCE_DETAILS, Schemas.INV);
    }
  }
}