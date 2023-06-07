using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Advertisement.Infrastructure.EntitiesSettings.File;

public class FileSetting
{
    public static void SetEntityBuilder(EntityTypeBuilder<Domain.Entites.File> entity)
    {
        entity.ToTable("file");
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).HasColumnName("file_id");
        entity.Property(e => e.Type).HasColumnName("type");
        entity.Property(e => e.Name).HasColumnName("name");
        entity.Property(e => e.Path).HasColumnName("path")
            .IsRequired(false);
        entity.Property(e => e.CreatedOn).HasColumnName("created_on");
        entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");
        
        
        entity.HasOne(file => file.Advertisement)
            .WithOne(advertisement => advertisement.File)
            .HasForeignKey<Domain.Entites.Advertisement>(file => file.FileId);
    }
}