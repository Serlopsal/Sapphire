using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SapphireApi.Data.Identity;
using SapphireApi.Data.Adminsitration.Country;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;

namespace SapphireApi.Data{
  internal class Sapphire_Context: IdentityDbContext<UserModel>{
    public Sapphire_Context(DbContextOptions options): base (options){}
    
    // Add Models DataSets [HERE]
    // Ex: public DbSet<DataModel> Model { get; set; }

    public DbSet<CountryModel> Country { get; set; }
    public DbSet<CompanyModel> Company { get; set; }

    protected override void OnModelCreating(ModelBuilder builder){
      base.OnModelCreating(builder);

      // Add Model Configuration Properties [HERE]
      // Ex: builder.ApplyConfiguration(new DataModelBuilder());

      builder.ApplyConfiguration(new UserModelBuilder());
      builder.ApplyConfiguration(new CountryModelBuilder());
      builder.ApplyConfiguration(new CompanyModelBuilder());

      // Add Relationships Configuration [HERE]
      // TEMPLATE 1 TO MANY RELATIONSHIP
        // ONE TO MANY [1 => *] 
        // builder
        //   .Entity<[MANY]>()
        //   .HasOne(PK => PK.[NAV_PROP_TO_ONE])
        //   .WithMany(FK => FK.[NAV_PROP_TO_MANY])
        //   .HasForeignKey(PK => PK.[KEY_OF_ONE]);

      builder
        .Entity<CompanyModel>()
        .HasOne(PK => PK.country)
        .WithMany(FK => FK.company)
        .HasForeignKey(PK => PK.id)
        .OnDelete(DeleteBehavior.Restrict);

      // Seeding
      // ONLY FIRST
      // new IdentitySeed(builder);
    }
  }
}