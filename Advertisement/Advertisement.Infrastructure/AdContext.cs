using Advertisement.Domain.Entites;
using Advertisement.Infrastructure.EntitiesSettings.Advertisement;
using Advertisement.Infrastructure.EntitiesSettings.Audience;
using Advertisement.Infrastructure.EntitiesSettings.Campaign;
using Advertisement.Infrastructure.EntitiesSettings.File;
using Advertisement.Infrastructure.EntitiesSettings.Interest;
using Advertisement.Infrastructure.EntitiesSettings.Objective;
using Microsoft.EntityFrameworkCore;
using File = System.IO.File;

namespace Advertisement.Infrastructure;

public class AdContext : DbContext
{
    public virtual DbSet<Domain.Entites.Advertisement> Advertisements { get; set; }
    public virtual DbSet<Audience> Audiences { get; set; }
    public virtual DbSet<Campaign> Campaigns { get; set; }
    public virtual DbSet<Interest> Interests { get; set; }
    public virtual DbSet<Objective> Objectives { get; set; }
    public virtual DbSet<Domain.Entites.File> Files { get; set; }

    public AdContext(DbContextOptions<AdContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        AdvertisementSetting.SetEntityBuilder(modelBuilder.Entity<Domain.Entites.Advertisement>());
        CampaignSetting.SetEntityBuilder(modelBuilder.Entity<Campaign>());
        AudienceSetting.SetEntityBuilder(modelBuilder.Entity<Audience>());
        ObjectiveSetting.SetEntityBuilder(modelBuilder.Entity<Objective>());
        FileSetting.SetEntityBuilder(modelBuilder.Entity<Advertisement.Domain.Entites.File>());
        InterestSetting.SetEntityBuilder(modelBuilder.Entity<Interest>());

        base.OnModelCreating(modelBuilder);
    }
}