using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Advertisement.Infrastructure.EntitiesSettings.Audience;

public class AudienceSetting
{
    public static void SetEntityBuilder(EntityTypeBuilder<Domain.Entites.Audience> entity)
    {
        entity.ToTable("audience");
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).HasColumnName("audience_id");
        entity.Property(e => e.Visualizations).HasColumnName("visualizations");
        entity.Property(e => e.Interests).HasColumnName("interest");
        entity.Property(e => e.CampaignId).HasColumnName("campaign_id");
        entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");
    }
}