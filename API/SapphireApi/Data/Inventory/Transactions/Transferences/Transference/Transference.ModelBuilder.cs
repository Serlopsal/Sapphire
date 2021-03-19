using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SapphireApi.Data.Shared.Normalize;

namespace SapphireApi.Data.Inventory.Transactions.Transferences.Documents {
  public class TransferenceModelBuilder: TransferTransactionModelBuilder<TransferenceModel> {
    public override void Configure(EntityTypeBuilder<TransferenceModel> builder) {
      base.Configure(builder);

      builder.ToTable(Schemas.INV + Tables.TRANSFERENCE);
    }
  }
}