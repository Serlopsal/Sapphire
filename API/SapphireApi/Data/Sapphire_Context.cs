using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SapphireApi.Data.Identity;
using SapphireApi.Data.Adminsitration.Country;
using SapphireApi.Data.Adminsitration.SystemInitialization.Company;
using SapphireApi.Data.Adminsitration.Setup.UOM;
using SapphireApi.Data.Adminsitration.Setup.UOM.Converter;
using SapphireApi.Data.Inventory.ItemsGroup;
using SapphireApi.Data.Inventory.Manufacters;
using SapphireApi.Data.Inventory.Items;

namespace SapphireApi.Data{
  public class Sapphire_Context: IdentityDbContext<UserModel>{
    public Sapphire_Context(DbContextOptions options): base (options){}
    
    // Add Models DataSets [HERE]
    // Ex: public DbSet<DataModel> Model { get; set; }

    public DbSet<CountryModel> Country { get; set; }
    public DbSet<CompanyModel> Company { get; set; }
    public DbSet<UOMModel> UOM { get; set; }
    public DbSet<UOMConverterModel> UOMConverter { get; set; }
    public DbSet<ManufacterModel> Manufacter { get; set; }
    public DbSet<ItemsGroupModel> ItemsGroup { get; set; }
    public DbSet<ItemModel> Item { get; set; }

    protected override void OnModelCreating(ModelBuilder builder){
      base.OnModelCreating(builder);

      // Add Model Configuration Properties [HERE]
      // Ex: builder.ApplyConfiguration(new DataModelBuilder());

      builder.ApplyConfiguration(new UserModelBuilder());
      builder.ApplyConfiguration(new CountryModelBuilder());
      builder.ApplyConfiguration(new CompanyModelBuilder());
      builder.ApplyConfiguration(new UOMModelBuilder());
      builder.ApplyConfiguration(new UOMConverterModelBuilder());
      builder.ApplyConfiguration(new ManufacterModelBuilder());
      builder.ApplyConfiguration(new ItemsGroupModelBuilder());
      builder.ApplyConfiguration(new ItemModelBuilder());

      // Add Relationships Configuration [HERE]
      // TEMPLATE 1 TO MANY RELATIONSHIP
        // ONE TO MANY [1 => *] 
        // builder
        //   .Entity<[MANY]>()
        //   .HasOne(PK => PK.[NAV_PROP_TO_ONE])
        //   .WithMany(FK => FK.[NAV_PROP_TO_MANY])
        //   .HasForeignKey(PK => PK.[KEY_OF_ONE]);

      // Configure Relationsships

      // 1 Country => * Company
      builder
        .Entity<CompanyModel>()
        .HasOne(PK => PK.country)
        .WithMany(FK => FK.company)
        .HasForeignKey(PK => PK.countryId)
        .OnDelete(DeleteBehavior.Restrict);

      // 1 Company => * User
      builder
        .Entity<UserModel>()
        .HasOne(PK => PK.company)
        .WithMany(FK => FK.users)
        .HasForeignKey(PK => PK.companyId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<UOMConverterModel>()
        .HasOne(PK => PK.fromOne)
        .WithMany(FK => FK.uomConverter_from)
        .HasForeignKey(PK => PK.fromOneId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<UOMConverterModel>()
        .HasOne(PK => PK.toMany)
        .WithMany(FK => FK.uomConverter_to)
        .HasForeignKey(PK => PK.toManyId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<ItemModel>()
        .HasOne(PK => PK.itemsGroup)
        .WithMany(FK => FK.items)
        .HasForeignKey(PK => PK.itemsGroupId)
        .OnDelete(DeleteBehavior.Restrict);

      builder
        .Entity<ItemModel>()
        .HasOne(PK => PK.manufacter)
        .WithMany(FK => FK.items)
        .HasForeignKey(PK => PK.mrcCode)
        .OnDelete(DeleteBehavior.Restrict);

        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.purchaseUOM)
          .WithMany(FK => FK.purItm)
          .HasForeignKey(PK => PK.purchaseUomId)
          .OnDelete(DeleteBehavior.Restrict);

        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.sellUOM)
          .WithMany(FK => FK.sellItm)
          .HasForeignKey(PK => PK.sellUomId)
          .OnDelete(DeleteBehavior.Restrict);

        builder
          .Entity<ItemModel>()
          .HasOne(PK => PK.inventoryUOM)
          .WithMany(FK => FK.invItm)
          .HasForeignKey(PK => PK.inventoryUomId)
          .OnDelete(DeleteBehavior.Restrict);

      // Seeding
      // ONLY FIRST
      // new IdentitySeed(builder);
    }
  }
}