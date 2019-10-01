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

        public virtual DbSet<contentDetails> contentDetails { get; set; }
        public virtual DbSet<pageInfo> pageInfo { get; set; }
        public virtual DbSet<resultItems> resultItems { get; set; }
        public virtual DbSet<snippet> snippet { get; set; }
        public virtual DbSet<videoItems> videoItems { get; set; }
        public virtual DbSet<VideoResults> VideoResults { get; set; }
        public virtual DbSet<YoutubeApiViewModels> YoutubeApiViewModels { get; set; }
        public virtual DbSet<YoutubeResults> YoutubeResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=myWebApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<contentDetails>(entity =>
            {
                entity.HasKey(e => e.videoId);

                entity.Property(e => e.videoId).ValueGeneratedNever();
            });

            modelBuilder.Entity<pageInfo>(entity =>
            {
                entity.HasKey(e => e.totalResults);
            });

            modelBuilder.Entity<resultItems>(entity =>
            {
                entity.HasIndex(e => e.contentDetailsvideoId);

                entity.HasIndex(e => e.kind);

                entity.Property(e => e.id).ValueGeneratedNever();

                entity.HasOne(d => d.contentDetailsvideo)
                    .WithMany(p => p.resultItems)
                    .HasForeignKey(d => d.contentDetailsvideoId);

                entity.HasOne(d => d.kindNavigation)
                    .WithMany(p => p.resultItems)
                    .HasForeignKey(d => d.kind);
            });

            modelBuilder.Entity<snippet>(entity =>
            {
                entity.HasKey(e => e.title);

                entity.Property(e => e.title).ValueGeneratedNever();
            });

            modelBuilder.Entity<videoItems>(entity =>
            {
                entity.HasIndex(e => e.kind);

                entity.HasIndex(e => e.snippettitle);

                entity.Property(e => e.id).ValueGeneratedNever();

                entity.HasOne(d => d.kindNavigation)
                    .WithMany(p => p.videoItems)
                    .HasForeignKey(d => d.kind);

                entity.HasOne(d => d.snippettitleNavigation)
                    .WithMany(p => p.videoItems)
                    .HasForeignKey(d => d.snippettitle);
            });

            modelBuilder.Entity<VideoResults>(entity =>
            {
                entity.HasKey(e => e.kind);

                entity.HasIndex(e => e.pageInfototalResults);

                entity.Property(e => e.kind).ValueGeneratedNever();

                entity.HasOne(d => d.pageInfototalResultsNavigation)
                    .WithMany(p => p.VideoResults)
                    .HasForeignKey(d => d.pageInfototalResults);
            });

            modelBuilder.Entity<YoutubeAPIViewModels>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<YoutubeResults>(entity =>
            {
                entity.HasKey(e => e.kind);

                entity.HasIndex(e => e.pageInfototalResults);

                entity.Property(e => e.kind).ValueGeneratedNever();

                entity.HasOne(d => d.pageInfototalResultsNavigation)
                    .WithMany(p => p.YoutubeResults)
                    .HasForeignKey(d => d.pageInfototalResults);
            });
        }
    }
}
