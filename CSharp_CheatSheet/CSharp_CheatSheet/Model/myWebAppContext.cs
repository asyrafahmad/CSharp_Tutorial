using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSharp_CheatSheet.Model
{
    public partial class myWebAppContext : DbContext
    {
        public myWebAppContext()
        {
        }

        public myWebAppContext(DbContextOptions<myWebAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContentDetails> ContentDetails { get; set; }
        public virtual DbSet<PageInfo> PageInfo { get; set; }
        public virtual DbSet<ResultItems> ResultItems { get; set; }
        public virtual DbSet<Snippet> Snippet { get; set; }
        public virtual DbSet<VideoItems> VideoItems { get; set; }
        public virtual DbSet<VideoResults> VideoResults { get; set; }
        public virtual DbSet<YoutubeVideoDetails> YoutubeApiviewModels { get; set; }
        public virtual DbSet<YoutubeResults> YoutubeResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=myWebApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentDetails>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("contentDetails");

                entity.Property(e => e.VideoId)
                    .HasColumnName("videoId")
                    .ValueGeneratedNever();

                entity.Property(e => e.VideoPublishedAt).HasColumnName("videoPublishedAt");
            });

            modelBuilder.Entity<PageInfo>(entity =>
            {
                entity.HasKey(e => e.TotalResults);

                entity.ToTable("pageInfo");

                entity.Property(e => e.TotalResults).HasColumnName("totalResults");

                entity.Property(e => e.ResultsPerPage).HasColumnName("resultsPerPage");
            });

            modelBuilder.Entity<ResultItems>(entity =>
            {
                entity.ToTable("resultItems");

                entity.HasIndex(e => e.ContentDetailsvideoId);

                entity.HasIndex(e => e.Kind);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContentDetailsvideoId).HasColumnName("contentDetailsvideoId");

                entity.Property(e => e.Etag).HasColumnName("etag");

                entity.Property(e => e.Kind).HasColumnName("kind");

                entity.HasOne(d => d.ContentDetailsvideo)
                    .WithMany(p => p.ResultItems)
                    .HasForeignKey(d => d.ContentDetailsvideoId);

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.ResultItems)
                    .HasForeignKey(d => d.Kind);
            });

            modelBuilder.Entity<Snippet>(entity =>
            {
                entity.HasKey(e => e.Title);

                entity.ToTable("snippet");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.PublishedAt).HasColumnName("publishedAt");
            });

            modelBuilder.Entity<VideoItems>(entity =>
            {
                entity.ToTable("videoItems");

                entity.HasIndex(e => e.Kind);

                entity.HasIndex(e => e.Snippettitle);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Etag).HasColumnName("etag");

                entity.Property(e => e.Kind).HasColumnName("kind");

                entity.Property(e => e.Snippettitle).HasColumnName("snippettitle");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.VideoItems)
                    .HasForeignKey(d => d.Kind);

                entity.HasOne(d => d.SnippettitleNavigation)
                    .WithMany(p => p.VideoItems)
                    .HasForeignKey(d => d.Snippettitle);
            });

            modelBuilder.Entity<VideoResults>(entity =>
            {
                entity.HasKey(e => e.Kind);

                entity.HasIndex(e => e.PageInfototalResults);

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .ValueGeneratedNever();

                entity.Property(e => e.Etag).HasColumnName("etag");

                entity.Property(e => e.PageInfototalResults).HasColumnName("pageInfototalResults");

                entity.HasOne(d => d.PageInfototalResultsNavigation)
                    .WithMany(p => p.VideoResults)
                    .HasForeignKey(d => d.PageInfototalResults);
            });

            modelBuilder.Entity<YoutubeVideoDetails>(entity =>
            {
                entity.ToTable("YoutubeAPIViewModels");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<YoutubeResults>(entity =>
            {
                entity.HasKey(e => e.Kind);

                entity.HasIndex(e => e.PageInfototalResults);

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .ValueGeneratedNever();

                entity.Property(e => e.Etag).HasColumnName("etag");

                entity.Property(e => e.NextPageToken).HasColumnName("nextPageToken");

                entity.Property(e => e.PageInfototalResults).HasColumnName("pageInfototalResults");

                entity.HasOne(d => d.PageInfototalResultsNavigation)
                    .WithMany(p => p.YoutubeResults)
                    .HasForeignKey(d => d.PageInfototalResults);
            });
        }
    }
}
