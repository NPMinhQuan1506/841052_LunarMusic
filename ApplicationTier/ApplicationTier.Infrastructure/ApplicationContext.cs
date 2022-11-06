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

        public virtual DbSet<VwWork> VwWorks { get; set; }
        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<MusLunarAuthor> MusLunarAuthors { get; set; } = null!;
        public virtual DbSet<MusLunarCustomer> MusLunarCustomers { get; set; } = null!;
        public virtual DbSet<MusLunarCustomerGroup> MusLunarCustomerGroups { get; set; } = null!;
        public virtual DbSet<MusLunarCustomerPlaylist> MusLunarCustomerPlaylists { get; set; } = null!;
        public virtual DbSet<MusLunarCustomerUser> MusLunarCustomerUsers { get; set; } = null!;
        public virtual DbSet<MusLunarEmployee> MusLunarEmployees { get; set; } = null!;
        public virtual DbSet<MusLunarMusicGenre> MusLunarMusicGenres { get; set; } = null!;
        public virtual DbSet<MusLunarNational> MusLunarNationals { get; set; } = null!;
        public virtual DbSet<MusLunarOrder> MusLunarOrders { get; set; } = null!;
        public virtual DbSet<MusLunarOrderDetail> MusLunarOrderDetails { get; set; } = null!;
        public virtual DbSet<MusLunarParameter> MusLunarParameters { get; set; } = null!;
        public virtual DbSet<MusLunarParameterType> MusLunarParameterTypes { get; set; } = null!;
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
            modelBuilder.Entity<VwWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwWork");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.ToTable("Work");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MusLunarAuthor>(entity =>
            {
                entity.ToTable("MusLunar_Author");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.NameNoSign).HasMaxLength(200);

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarCustomer>(entity =>
            {
                entity.ToTable("MusLunar_Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AssistantEmail).HasMaxLength(300);

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.NameNoSign).HasMaxLength(50);

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarCustomerGroup>(entity =>
            {
                entity.ToTable("MusLunar_CustomerGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarCustomerPlaylist>(entity =>
            {
                entity.ToTable("MusLunar_CustomerPlaylist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LastListeningTime).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.SongId).HasColumnName("SongID");

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.MusLunarCustomerPlaylists)
                //    .HasForeignKey(d => d.CustomerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_MusLunar_CustomerPlaylist_To_MusLunar_Customer")
                      ;

                //entity.HasOne(d => d.Song)
                //    .WithMany(p => p.MusLunarCustomerPlaylists)
                //    .HasForeignKey(d => d.SongId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_MusLunar_CustomerPlaylist_To_MusLunar_Song")
                      ;
            });

            modelBuilder.Entity<MusLunarCustomerUser>(entity =>
            {
                entity.ToTable("MusLunar_CustomerUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BlockTime).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.IsBlock).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastSignin).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(2000);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.Property(e => e.Username).HasMaxLength(200);

                entity.HasOne(d => d.Customer)
                    //.WithMany(p => p.MusLunarCustomerUsers)
                    //.HasForeignKey(d => d.CustomerId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_CustomerUser_To_MusLunar_Customer")
                    ;
            });

            modelBuilder.Entity<MusLunarEmployee>(entity =>
            {
                entity.ToTable("MusLunar_Employee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AssistantEmail).HasMaxLength(300);

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.NameNoSign)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Gender)
                    //.WithMany(p => p.MusLunarEmployees)
                    //.HasForeignKey(d => d.GenderId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Employee_To_MusLunar_Pararameter")
                    ;
            });

            modelBuilder.Entity<MusLunarMusicGenre>(entity =>
            {
                entity.ToTable("MusLunar_Music_Genres");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarNational>(entity =>
            {
                entity.ToTable("MusLunar_National");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarOrder>(entity =>
            {
                entity.ToTable("MusLunar_Order");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Customer)
                    //.WithMany(p => p.MusLunarOrders)
                    //.HasForeignKey(d => d.CustomerId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Order_To_MusLunar_Customer")
                    ;
            });

            modelBuilder.Entity<MusLunarOrderDetail>(entity =>
            {
                entity.ToTable("MusLunar_OrderDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiscountedPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Modified).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SongId).HasColumnName("SongID");

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarParameter>(entity =>
            {
                entity.ToTable("MusLunar_Parameter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ParaTypeId).HasColumnName("ParaTypeID");

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.Property(e => e.Value).HasMaxLength(200);

                entity.HasOne(d => d.ParaType)
                    //.WithMany(p => p.MusLunarParameters)
                    //.HasForeignKey(d => d.ParaTypeId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Pararameter_To_MusLunar_Pararameter_Type")
                    ;
            });

            modelBuilder.Entity<MusLunarParameterType>(entity =>
            {
                entity.ToTable("MusLunar_Parameter_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Note)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarSinger>(entity =>
            {
                entity.ToTable("MusLunar_Singer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.NameNoSign).HasMaxLength(200);

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Gender)
                    //.WithMany(p => p.MusLunarSingers)
                    //.HasForeignKey(d => d.GenderId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Singer_To_MusLunar_Pararameter")
                    ;
            });

            modelBuilder.Entity<MusLunarSong>(entity =>
            {
                entity.ToTable("MusLunar_Song");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.GenresId).HasColumnName("GenresID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IsPro).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.NationalId).HasColumnName("NationalID");

                entity.Property(e => e.SingerId).HasColumnName("SingerID");

                entity.Property(e => e.Source).HasMaxLength(2000);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Author)
                    //.WithMany(p => p.MusLunarSongs)
                    //.HasForeignKey(d => d.AuthorId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Song_To_MusLunar_Author")
                    ;

                entity.HasOne(d => d.Genres)
                    //.WithMany(p => p.MusLunarSongs)
                    //.HasForeignKey(d => d.GenresId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Song_To_MusLunar_Music_Genres")
                    ;

                entity.HasOne(d => d.Group)
                    //.WithMany(p => p.MusLunarSongs)
                    //.HasForeignKey(d => d.GroupId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Song_To_MusLunar_SongGroup")
                    ;

                entity.HasOne(d => d.Singer)
                    //.WithMany(p => p.MusLunarSongs)
                    //.HasForeignKey(d => d.SingerId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_Song_To_MusLunar_Singer")
                    ;
            });

            modelBuilder.Entity<MusLunarSongGroup>(entity =>
            {
                entity.ToTable("MusLunar_SongGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MusLunarUser>(entity =>
            {
                entity.ToTable("MusLunar_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastSignin).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(2000);

                entity.Property(e => e.State).HasDefaultValueSql("((1))");

                entity.Property(e => e.Username).HasMaxLength(200);

                entity.HasOne(d => d.Employee)
                    //.WithMany(p => p.MusLunarUsers)
                    //.HasForeignKey(d => d.EmployeeId)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("FK_MusLunar_User_To_MusLunar_Employee")
                    ;
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
