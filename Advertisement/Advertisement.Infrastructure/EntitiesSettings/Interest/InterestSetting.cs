
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Advertisement.Infrastructure.EntitiesSettings.Interest;

public class InterestSetting
{
    public static void SetEntityBuilder(EntityTypeBuilder<Domain.Entites.Interest> entity) 
    {
        entity.ToTable("interest");
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).HasColumnName("interest_id");
        entity.Property(e => e.Type).HasColumnName("type");
        entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");
        entity.UsePropertyAccessMode(PropertyAccessMode.Property);
    }
    
}