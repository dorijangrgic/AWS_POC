using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleMinimalApi.DataAccess.DAO;

namespace SimpleMinimalApi.DataAccess.Configurations;

public class PdfConfig : IEntityTypeConfiguration<Pdf>
{
  public void Configure(EntityTypeBuilder<Pdf> builder)
  {
    builder.ToTable("pdf");

    builder.HasKey(x => x.Id).HasName("pk_pdf");

    builder.Property(x => x.Id).UseIdentityColumn().IsRequired().HasColumnName("id");
    builder.Property(x => x.Name).IsRequired().HasMaxLength(128).HasColumnName("name");
    builder.Property(x => x.Content).IsRequired().HasColumnName("content");
  }
}
