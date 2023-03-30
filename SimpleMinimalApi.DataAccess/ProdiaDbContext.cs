using Microsoft.EntityFrameworkCore;
using SimpleMinimalApi.DataAccess.DAO;

namespace SimpleMinimalApi.DataAccess;

public class ProdiaDbContext : DbContext
{
	public ProdiaDbContext(DbContextOptions<ProdiaDbContext> options) : base(options)
	{
	}

	public DbSet<MetaTag> MetaTag { get; set; }
	public DbSet<Pdf> Pdf { get; set; }
	public DbSet<PdfMetaTag> PdfMetaTag { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.HasDefaultSchema("public");

		builder.ApplyConfigurationsFromAssembly(typeof(ProdiaDbContext).Assembly);
	}
}