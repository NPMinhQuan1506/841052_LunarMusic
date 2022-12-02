using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ApplicationTier.Domain.Entities;

namespace ApplicationTier.Domain.Context
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MusLunarMusicGenre> MusLunarMusicGenres { get; set; } = null!;
        public virtual DbSet<MusLunarSinger> MusLunarSingers { get; set; } = null!;
        public virtual DbSet<MusLunarSong> MusLunarSongs { get; set; } = null!;
        public virtual DbSet<MusLunarSongGroup> MusLunarSongGroups { get; set; } = null!;
        public virtual DbSet<MusLunarUser> MusLunarUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\\\\\\\NPMINHQUAN,1433;Initial Catalog=LunarMusic;Persist Security Info=True;User ID=lunartest;Password=123456;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusLunarMusicGenre>(entity =>
            {
                entity.ToTable("MusLunar_Music_Genres", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarSinger>(entity =>
            {
                entity.ToTable("MusLunar_Singer", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarSong>(entity =>
            {
                entity.ToTable("MusLunar_Song", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.GenresId).HasColumnName("GenresID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.SingerId).HasColumnName("SingerID");

                entity.Property(e => e.Source).HasMaxLength(2000);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarSongGroup>(entity =>
            {
                entity.ToTable("MusLunar_SongGroup", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarUser>(entity =>
            {
                entity.ToTable("MusLunar_User", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(2000);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.Property(e => e.Username).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
