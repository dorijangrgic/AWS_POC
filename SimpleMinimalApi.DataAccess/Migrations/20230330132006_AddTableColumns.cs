using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleMinimalApi.DataAccess.Migrations
{
    public partial class AddTableColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PdfId",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "pdf_id");

            migrationBuilder.RenameColumn(
                name: "MetaTagId",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "meta_tag_id");

            migrationBuilder.RenameIndex(
                name: "IX_pdf_meta_tag_PdfId",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "IX_pdf_meta_tag_pdf_id");

            migrationBuilder.RenameIndex(
                name: "IX_pdf_meta_tag_MetaTagId",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "IX_pdf_meta_tag_meta_tag_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "public",
                table: "pdf",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Content",
                schema: "public",
                table: "pdf",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "pdf",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Value",
                schema: "public",
                table: "meta_tags",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "meta_tags",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pdf_id",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "PdfId");

            migrationBuilder.RenameColumn(
                name: "meta_tag_id",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "MetaTagId");

            migrationBuilder.RenameIndex(
                name: "IX_pdf_meta_tag_pdf_id",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "IX_pdf_meta_tag_PdfId");

            migrationBuilder.RenameIndex(
                name: "IX_pdf_meta_tag_meta_tag_id",
                schema: "public",
                table: "pdf_meta_tag",
                newName: "IX_pdf_meta_tag_MetaTagId");

            migrationBuilder.RenameColumn(
                name: "name",
                schema: "public",
                table: "pdf",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "content",
                schema: "public",
                table: "pdf",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "pdf",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "value",
                schema: "public",
                table: "meta_tags",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "meta_tags",
                newName: "Id");
        }
    }
}
