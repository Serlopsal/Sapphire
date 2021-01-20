using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SapphireApi.Data{
  public class Sapphire_Context: IdentityDbContext{
    public Sapphire_Context(DbContextOptions options): base (options){}
    
    // Add Models DataSets [HERE]
    // Ex: public DbSet<DataModel> Model { get; set; }

    protected override void OnModelCreating(ModelBuilder builder){
      base.OnModelCreating(builder);

      // Add Model Configuration Properties [HERE]
      // Ex: builder.ApplyConfiguration(new DataModelBuilder());

      // Add Relationships Configuration [HERE]
      // TEMPLATE 1 TO MANY RELATIONSHIP
            // 1  => * 
            // builder
            //     .Entity<>()
            //     .HasOne(PK => PK.)
            //     .WithMany(FK => FK.)
            //     .HasForeignKey(PK => PK.);
    }
  }
}