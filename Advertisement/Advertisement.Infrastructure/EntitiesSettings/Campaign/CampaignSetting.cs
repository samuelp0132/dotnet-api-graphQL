using Advertisement.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Advertisement.Infrastructure.EntitiesSettings.Campaign;

public class CampaignSetting
{
    public static void SetEntityBuilder(EntityTypeBuilder<Domain.Entites.Campaign> entity)
    {
        entity.ToTable("campaign");
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).HasColumnName("campaign_id");
        entity.Property(e => e.Name).HasColumnName("name");
        entity.Property(e => e.Description).HasColumnName("description");
        entity.Property(e => e.StartDate).HasColumnName("start_date");
        entity.Property(e => e.EndDate).HasColumnName("end_date");
        entity.Property(e => e.Status).HasColumnName("status");
        entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");
        entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        entity.HasOne(campaign => campaign.Audience)
            .WithOne(audience => audience.Campaign)
            .HasForeignKey<Domain.Entites.Audience>(audience => audience.CampaignId);

        entity.HasMany(campaign => campaign.Advertisement)
            .WithOne(advertisement => advertisement.Campaign)
            .HasForeignKey(advertisement => advertisement.CampaignId);
        
        entity.UsePropertyAccessMode(PropertyAccessMode.Property);
        
    }
}