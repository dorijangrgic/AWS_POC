using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SimpleMinimalApi.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "meta_tags",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<int>(type: "integer", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_meta_tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pdf",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pdf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pdf_meta_tag",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PdfId = table.Column<int>(type: "integer", nullable: false),
                    MetaTagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pdf_meta_tag", x => x.Id);
                    table.ForeignKey(
                        name: "fk_pdf_meta_tag-meta_tag",
                        column: x => x.MetaTagId,
                        principalSchema: "public",
                        principalTable: "meta_tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pdf_meta_tag-pdf",
                        column: x => x.PdfId,
                        principalSchema: "public",
                        principalTable: "pdf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pdf_meta_tag_MetaTagId",
                schema: "public",
                table: "pdf_meta_tag",
                column: "MetaTagId");

            migrationBuilder.CreateIndex(
                name: "IX_pdf_meta_tag_PdfId",
                schema: "public",
                table: "pdf_meta_tag",
                column: "PdfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pdf_meta_tag",
                schema: "public");

            migrationBuilder.DropTable(
                name: "meta_tags",
                schema: "public");

            migrationBuilder.DropTable(
                name: "pdf",
                schema: "public");
        }
    }
}
