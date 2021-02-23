using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public static class IdentificableModelRelationshipsBuilder<TEntity> where TEntity: IdentificableModel{
    public static void BuildRelationships(EntityTypeBuilder<TEntity> builder){

      builder
        .HasOne(model => model.obj)
        .WithMany()
        .HasForeignKey(model => model.objType)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}
