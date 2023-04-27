using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1
{
    public partial class sanatoriyContext : DbContext
    {
        public sanatoriyContext()
        {
        }

        public sanatoriyContext(DbContextOptions<sanatoriyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddService> AddService { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("server=localhost;userid=Harry;password=123;database=sanatoriy");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddService>(entity =>
            {
                entity.HasKey(e => e.Serviceid)
                    .HasName("add_service_pk");

                entity.ToTable("add_service");

                entity.Property(e => e.Serviceid)
                    .HasColumnName("serviceid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Breakfast).HasColumnName("breakfast");

                entity.Property(e => e.Dinner).HasColumnName("dinner");

                entity.Property(e => e.Idperson).HasColumnName("idperson");

                entity.Property(e => e.Laundry).HasColumnName("laundry");

                entity.Property(e => e.Lunch).HasColumnName("lunch");

                entity.Property(e => e.Spa).HasColumnName("spa");

                entity.HasOne(d => d.IdpersonNavigation)
                    .WithMany(p => p.AddService)
                    .HasForeignKey(d => d.Idperson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("add_service_fk");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Personaid)
                    .HasName("person_pk");

                entity.ToTable("person");

                entity.Property(e => e.Personaid)
                    .HasColumnName("personaid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Addition).HasColumnName("addition");

                entity.Property(e => e.Amountofchildren).HasColumnName("amountofchildren");

                entity.Property(e => e.Arrivaldate).HasColumnName("arrivaldate");

                entity.Property(e => e.Departuredate).HasColumnName("departuredate");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Firstname).HasColumnName("firstname");

                entity.Property(e => e.Idroom).HasColumnName("idroom");

                entity.Property(e => e.Lastname).HasColumnName("lastname");

                entity.Property(e => e.Numberofadults).HasColumnName("numberofadults");

                entity.Property(e => e.Pasportinfo).HasColumnName("pasportinfo");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Surname).HasColumnName("surname");

                entity.HasOne(d => d.IdroomNavigation)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.Idroom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("person_fk");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Roleid)
                    .HasColumnName("roleid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Rolename).HasColumnName("rolename");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("room");

                entity.Property(e => e.Roomid)
                    .HasColumnName("roomid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Room1).HasColumnName("room");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("user_pk");

                entity.ToTable("users");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Idrole).HasColumnName("idrole");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.HasOne(d => d.IdroleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Idrole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
