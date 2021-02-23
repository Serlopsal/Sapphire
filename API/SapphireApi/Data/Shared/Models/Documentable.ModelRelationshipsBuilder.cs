using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public static class DocumentableModelRelationshipsBuilder<TEntity> where TEntity: DocumentableModel {
    public static void BuildRelationships(EntityTypeBuilder<TEntity> builder){
      
      builder
        .HasOne(PK => PK.serie)
        .WithMany()
        .HasForeignKey(PK => PK.serieId)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}