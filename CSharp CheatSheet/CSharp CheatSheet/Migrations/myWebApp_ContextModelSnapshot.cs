﻿// <auto-generated />
using System;
using CheatSheet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharpCheatSheet.Migrations
{
    [DbContext(typeof(DbContext_Model.myWebApp_Context))]
    partial class myWebApp_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CheatSheet.Models.contentDetails", b =>
                {
                    b.Property<string>("videoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("videoPublishedAt");

                    b.HasKey("videoId");

                    b.ToTable("contentDetails");
                });

            modelBuilder.Entity("CheatSheet.Models.pageInfo", b =>
                {
                    b.Property<int>("totalResults")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("resultsPerPage");

                    b.HasKey("totalResults");

                    b.ToTable("pageInfo");
                });

            modelBuilder.Entity("CheatSheet.Models.resultItems", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("contentDetailsvideoId");

                    b.Property<string>("etag");

                    b.Property<string>("kind");

                    b.HasKey("id");

                    b.HasIndex("contentDetailsvideoId");

                    b.HasIndex("kind");

                    b.ToTable("resultItems");
                });

            modelBuilder.Entity("CheatSheet.Models.snippet", b =>
                {
                    b.Property<string>("title")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<DateTime>("publishedAt");

                    b.HasKey("title");

                    b.ToTable("snippet");
                });

            modelBuilder.Entity("CheatSheet.Models.videoItems", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("etag");

                    b.Property<string>("kind");

                    b.Property<string>("snippettitle");

                    b.HasKey("id");

                    b.HasIndex("kind");

                    b.HasIndex("snippettitle");

                    b.ToTable("videoItems");
                });

            modelBuilder.Entity("CheatSheet.Models.VideoResult", b =>
                {
                    b.Property<string>("kind")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("etag");

                    b.Property<int?>("pageInfototalResults");

                    b.HasKey("kind");

                    b.HasIndex("pageInfototalResults");

                    b.ToTable("VideoResults");
                });

            modelBuilder.Entity("CheatSheet.Models.YoutubeAPIViewModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<string>("Tumbnail");

                    b.HasKey("Id");

                    b.ToTable("YoutubeAPIViewModels");
                });

            modelBuilder.Entity("CheatSheet.Models.YoutubeResult", b =>
                {
                    b.Property<string>("kind")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("etag");

                    b.Property<string>("nextPageToken");

                    b.Property<int?>("pageInfototalResults");

                    b.HasKey("kind");

                    b.HasIndex("pageInfototalResults");

                    b.ToTable("YoutubeResults");
                });

            modelBuilder.Entity("CheatSheet.Models.resultItems", b =>
                {
                    b.HasOne("CheatSheet.Models.contentDetails", "contentDetails")
                        .WithMany()
                        .HasForeignKey("contentDetailsvideoId");

                    b.HasOne("CheatSheet.Models.YoutubeResult")
                        .WithMany("items")
                        .HasForeignKey("kind");
                });

            modelBuilder.Entity("CheatSheet.Models.videoItems", b =>
                {
                    b.HasOne("CheatSheet.Models.VideoResult")
                        .WithMany("items")
                        .HasForeignKey("kind");

                    b.HasOne("CheatSheet.Models.snippet", "snippet")
                        .WithMany()
                        .HasForeignKey("snippettitle");
                });

            modelBuilder.Entity("CheatSheet.Models.VideoResult", b =>
                {
                    b.HasOne("CheatSheet.Models.pageInfo", "pageInfo")
                        .WithMany()
                        .HasForeignKey("pageInfototalResults");
                });

            modelBuilder.Entity("CheatSheet.Models.YoutubeResult", b =>
                {
                    b.HasOne("CheatSheet.Models.pageInfo", "pageInfo")
                        .WithMany()
                        .HasForeignKey("pageInfototalResults");
                });
#pragma warning restore 612, 618
        }
    }
}
