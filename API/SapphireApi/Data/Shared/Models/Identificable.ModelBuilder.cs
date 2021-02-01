using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  internal abstract class IdentificableModelBuilder<TEntity>: IEntityTypeConfiguration<TEntity> where TEntity: IdentificableModel{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder){
      builder.HasKey(b => b.id);
      builder.Property(p => p.id).UseIdentityColumn();
    }
  }
}