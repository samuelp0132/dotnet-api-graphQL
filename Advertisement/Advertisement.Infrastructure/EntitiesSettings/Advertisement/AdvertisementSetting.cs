using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Advertisement.Infrastructure.EntitiesSettings.Advertisement;

public class AdvertisementSetting
{
    public static void SetEntityBuilder(EntityTypeBuilder<Domain.Entites.Advertisement> entity)
    {
        entity.ToTable("advertisement");
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).HasColumnName("advertisement_id");
        entity.Property(e => e.Title).HasColumnName("title");
        entity.Property(e => e.Description).HasColumnName("description");
        entity.Property(e => e.Url).HasColumnName("url");
        entity.Property(e => e.Aspect).HasColumnName("aspect");
        entity.Property(e => e.CampaignId).HasColumnName("campaign_id")
            .IsRequired(false);
        entity.Property(e => e.FileId).HasColumnName("file_id");
        entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");
        entity.UsePropertyAccessMode(PropertyAccessMode.Property);
    }
}