using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleMinimalApi.DataAccess.DAO;

namespace SimpleMinimalApi.DataAccess.Configurations;

public class PdfMetaTagConfig : IEntityTypeConfiguration<PdfMetaTag>
{
  public void Configure(EntityTypeBuilder<PdfMetaTag> builder)
  {
    builder.ToTable("pdf_meta_tag");

    builder.HasKey(x => x.Id).HasName("pk_pdf_meta_tag");

    builder.Property(x => x.Id).UseIdentityColumn().IsRequired().HasColumnName("id");
    builder.Property(x => x.PdfId).IsRequired().HasColumnName("pdf_id");
    builder.Property(x => x.MetaTagId).IsRequired().HasColumnName("meta_tag_id");

    builder.HasOne(x => x.Pdf).WithMany(x => x.PdfMetaTags).HasForeignKey(x => x.PdfId)
      .HasConstraintName("fk_pdf_meta_tag-pdf");

    builder.HasOne(x => x.MetaTag).WithMany(x => x.PdfMetaTags).HasForeignKey(x => x.MetaTagId)
      .HasConstraintName("fk_pdf_meta_tag-meta_tag");
  }
}
