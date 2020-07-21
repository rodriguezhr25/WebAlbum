﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAlbum.Data;

namespace WebAlbum.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20200721205903_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAlbum.Models.Album", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("title");

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("WebAlbum.Models.Comment", b =>
                {
                    b.Property<int>("id");

                    b.Property<int?>("Commentid");

                    b.Property<int?>("Photoid");

                    b.Property<string>("body");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<int>("postId");

                    b.HasKey("id");

                    b.HasIndex("Commentid");

                    b.HasIndex("Photoid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebAlbum.Models.Photo", b =>
                {
                    b.Property<int>("id");

                    b.Property<int>("albumId");

                    b.Property<string>("thumbnailUrl");

                    b.Property<string>("title");

                    b.Property<string>("url");

                    b.HasKey("id");

                    b.HasIndex("albumId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("WebAlbum.Models.Comment", b =>
                {
                    b.HasOne("WebAlbum.Models.Comment")
                        .WithMany("Comments")
                        .HasForeignKey("Commentid");

                    b.HasOne("WebAlbum.Models.Photo")
                        .WithMany("Comments")
                        .HasForeignKey("Photoid");
                });

            modelBuilder.Entity("WebAlbum.Models.Photo", b =>
                {
                    b.HasOne("WebAlbum.Models.Album")
                        .WithMany("Photos")
                        .HasForeignKey("albumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
