using ApplicationTier.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Infrastructure
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

                entity.Property(e => e.SingerId).HasColumnName("SingerID");

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
