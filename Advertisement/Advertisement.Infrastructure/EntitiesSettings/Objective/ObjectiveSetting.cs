using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Advertisement.Infrastructure.EntitiesSettings.Objective;

public class ObjectiveSetting
{
    public static void SetEntityBuilder(EntityTypeBuilder<Domain.Entites.Objective> entity)
    {
        entity.ToTable("objective");
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).HasColumnName("objective_id");
        entity.Property(e => e.Type).HasColumnName("type");
        entity.Property(e => e.Description).HasColumnName("description");
        entity.Property(e => e.CampaignId).HasColumnName("campaign_id");
        entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");
        entity.UsePropertyAccessMode(PropertyAccessMode.Property);
    }
}