﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SimpleMinimalApi.DataAccess;

#nullable disable

namespace SimpleMinimalApi.DataAccess.Migrations
{
    [DbContext(typeof(ProdiaDbContext))]
    [Migration("20230330131811_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SimpleMinimalApi.DataAccess.DAO.MetaTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Value")
                        .HasMaxLength(128)
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("pk_meta_tag");

                    b.ToTable("meta_tags", "public");
                });

            modelBuilder.Entity("SimpleMinimalApi.DataAccess.DAO.Pdf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id")
                        .HasName("pk_pdf");

                    b.ToTable("pdf", "public");
                });

            modelBuilder.Entity("SimpleMinimalApi.DataAccess.DAO.PdfMetaTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MetaTagId")
                        .HasColumnType("integer");

                    b.Property<int>("PdfId")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("pk_pdf_meta_tag");

                    b.HasIndex("MetaTagId");

                    b.HasIndex("PdfId");

                    b.ToTable("pdf_meta_tag", "public");
                });

            modelBuilder.Entity("SimpleMinimalApi.DataAccess.DAO.PdfMetaTag", b =>
                {
                    b.HasOne("SimpleMinimalApi.DataAccess.DAO.MetaTag", "MetaTag")
                        .WithMany("PdfMetaTags")
                        .HasForeignKey("MetaTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_pdf_meta_tag-meta_tag");

                    b.HasOne("SimpleMinimalApi.DataAccess.DAO.Pdf", "Pdf")
                        .WithMany("PdfMetaTags")
                        .HasForeignKey("PdfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_pdf_meta_tag-pdf");

                    b.Navigation("MetaTag");

                    b.Navigation("Pdf");
                });

            modelBuilder.Entity("SimpleMinimalApi.DataAccess.DAO.MetaTag", b =>
                {
                    b.Navigation("PdfMetaTags");
                });

            modelBuilder.Entity("SimpleMinimalApi.DataAccess.DAO.Pdf", b =>
                {
                    b.Navigation("PdfMetaTags");
                });
#pragma warning restore 612, 618
        }
    }
}
