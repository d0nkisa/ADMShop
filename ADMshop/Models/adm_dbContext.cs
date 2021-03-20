using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ADMshop.Models
{
    public partial class adm_dbContext : DbContext
    {
        public adm_dbContext()
        {
        }

        public adm_dbContext(DbContextOptions<adm_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Offers> Offers { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=adm_db; uID=root; pwd=root; persistsecurityinfo=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PRIMARY");

                entity.ToTable("admins");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.HasOne(d => d.Admin)
                    .WithOne(p => p.Admins)
                    .HasForeignKey<Admins>(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_admins_users");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PRIMARY");

                entity.ToTable("countries");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.Property(e => e.LoginId).HasColumnName("login_id");

                entity.Property(e => e.Pasword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Offers>(entity =>
            {
                entity.HasKey(e => e.OfferId)
                    .HasName("PRIMARY");

                entity.ToTable("offers");

                entity.HasIndex(e => e.Category)
                    .HasName("fk_offers_category_idx");

                entity.HasIndex(e => e.TownId)
                    .HasName("fk_offers_users");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_offers");

                entity.Property(e => e.OfferId).HasColumnName("offer_id");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasColumnType("longblob");

                entity.Property(e => e.ItemState).HasColumnName("item_state");

                entity.Property(e => e.OfferDescription)
                    .IsRequired()
                    .HasColumnName("offer_description")
                    .HasMaxLength(500);

                entity.Property(e => e.OfferHeading)
                    .IsRequired()
                    .HasColumnName("offer_heading")
                    .HasMaxLength(50);

                entity.Property(e => e.OfferPrice)
                    .HasColumnName("offer_price")
                    .HasColumnType("decimal(11,0)");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.TownId).HasColumnName("town_ID");

                entity.Property(e => e.UserId).HasColumnName("user_ID");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_offers_category");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_offers_users");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_offers");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Towns>(entity =>
            {
                entity.HasKey(e => e.TownId)
                    .HasName("PRIMARY");

                entity.ToTable("towns");

                entity.HasIndex(e => e.CountryCode)
                    .HasName("fk_towns_counries");

                entity.Property(e => e.TownId).HasColumnName("town_id");

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasColumnName("town_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Towns)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("fk_towns_counries");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.HasIndex(e => e.CountryId)
                    .HasName("fk_users_countries");

                entity.HasIndex(e => e.RoleId)
                    .HasName("fk_users_roles");

                entity.HasIndex(e => e.TownId)
                    .HasName("fk_users_towns");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CountryId).HasColumnName("country_ID");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.RoleId).HasColumnName("role_ID");

                entity.Property(e => e.TownId).HasColumnName("town_ID");

                entity.Property(e => e.UserImage)
                    .HasColumnName("user_image")
                    .HasColumnType("mediumblob");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_countries");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_roles");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_towns");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Users)
                    .HasForeignKey<Users>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_login");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
