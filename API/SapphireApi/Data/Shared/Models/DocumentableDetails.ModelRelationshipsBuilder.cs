using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SapphireApi.Data.Shared.Models {
  public static class DocumentableDetailsModelRelationshipsBuilder<TEntity, DetailOf>
  where DetailOf: DocumentableModel 
  where TEntity: DocumentableDetailsModel<DetailOf>{
    public static void BuildRelationships(EntityTypeBuilder<TEntity> builder){
      
      builder
        .HasOne(PK => PK.master)
        .WithMany()
        .HasForeignKey(PK => PK.masterId)
        .OnDelete(DeleteBehavior.Restrict);
        
      builder
        .HasOne(PK => PK.item)
        .WithMany()
        .HasForeignKey(PK => PK.itemCode)
        .OnDelete(DeleteBehavior.Restrict);
    }
  }
}