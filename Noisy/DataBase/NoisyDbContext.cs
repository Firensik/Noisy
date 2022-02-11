using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noisy.DataBase
{
    public class NoisyDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OGQBS2U;Database=E_muzykaEF;Trusted_Connection=True");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Login).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().HasOne<Supplier>(x => x.Supplier).WithOne(x => x.User).HasForeignKey<User>(x => x.SupplierId);

            modelBuilder.Entity<Supplier>().HasKey(x => x.Id);
            modelBuilder.Entity<Supplier>().Property(x => x.Name).HasMaxLength(500).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.UserId).IsRequired();
            modelBuilder.Entity<Supplier>().HasMany(x => x.Albums).WithOne(x => x.Supplier).HasForeignKey(x => x.SupplierId);

            modelBuilder.Entity<Album>().HasKey(x => x.Id);
            modelBuilder.Entity<Album>().Property(x => x.ArtistName).HasMaxLength(500).IsRequired();
            modelBuilder.Entity<Album>().Property(x => x.TitleAlbum).HasMaxLength(500).IsRequired();
            modelBuilder.Entity<Album>().Property(x => x.VersionAlbum).HasMaxLength(500).IsRequired();
            modelBuilder.Entity<Album>().Property(x => x.PublicationDate).IsRequired();
            modelBuilder.Entity<Album>().HasMany(x => x.Songs).WithOne(x => x.Album).HasForeignKey(x => x.AlbumId);

            modelBuilder.Entity<Song>().HasKey(x => x.Id);
            modelBuilder.Entity<Song>().Property(x => x.Time).IsRequired();
            modelBuilder.Entity<Song>().Property(x => x.Title).HasMaxLength(500).IsRequired();

        }
    }
}
