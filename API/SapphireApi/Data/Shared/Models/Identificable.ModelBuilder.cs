using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public abstract class IdentificableModelBuilder<TEntity>: AuditableModelBuilder<TEntity> where TEntity: IdentificableModel{
    public override void Configure(EntityTypeBuilder<TEntity> builder){
      base.Configure(builder);

      builder.HasKey(b => b.id);
      builder.Property(p => p.id).ValueGeneratedOnAdd();
    }
  }
}