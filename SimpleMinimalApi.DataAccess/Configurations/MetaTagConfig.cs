using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleMinimalApi.DataAccess.DAO;

namespace SimpleMinimalApi.DataAccess.Configurations;

public class MetaTagConfig : IEntityTypeConfiguration<MetaTag>
{
	public void Configure(EntityTypeBuilder<MetaTag> builder)
	{
		builder.ToTable("meta_tags");

		builder.HasKey(x => x.Id).HasName("pk_meta_tag");

		builder.Property(x => x.Id).UseIdentityColumn().IsRequired().HasColumnName("id");
		builder.Property(x => x.Value).IsRequired().HasMaxLength(128).HasColumnName("value");
	}
}