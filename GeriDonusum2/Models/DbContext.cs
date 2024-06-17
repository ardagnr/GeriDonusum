using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeriDonusum2.Models
{

    public class GeriDonusumDbContext : DbContext
    {
        public GeriDonusumDbContext() : base("name=GeriDonusum2")
        {
        }

        public DbSet<Kullanicilars> Kullanicilar { get; set; }
        public DbSet<Urunlers> Urunler { get; set; }
        public DbSet<Sehirlers> Sehirler { get; set; }
        public DbSet<Ilces> Ilce { get; set; }
        public DbSet<Sirketler> Sirketler { get; set; }
        public DbSet<Elemanlar> Elemanlar { get; set; }
        public DbSet<Kullanicilar_urunler> Kullanicilar_urunler { get; set; }
        public DbSet<Pozisyonlar> Pozisyonlar { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanicilar_urunler>()
                .HasRequired(ku => ku.Kullanicilar)
                .WithMany(k => k.KullaniciUrunler)
                .HasForeignKey(ku => ku.kullanici_id);

            modelBuilder.Entity<Kullanicilar_urunler>()
                .HasRequired(ku => ku.Urunler)
                .WithMany(u => u.KullaniciUrunler)
                .HasForeignKey(ku => ku.urun_id);

            modelBuilder.Entity<Kullanicilar_urunler>()
                .HasRequired(ku => ku.Sehirler)
                .WithMany(s => s.KullaniciUrunler)
                .HasForeignKey(ku => ku.sehir_id);

            modelBuilder.Entity<Kullanicilar_urunler>()
                .HasRequired(ku => ku.Ilce)
                .WithMany(i => i.KullaniciUrunler)
                .HasForeignKey(ku => ku.ilce_id);

            modelBuilder.Entity<Elemanlar>()
                .HasRequired(e => e.Sirketler)
                .WithMany(s => s.Elemanlar)
                .HasForeignKey(e => e.sirket_id);

            modelBuilder.Entity<Elemanlar>()
            .HasRequired(e => e.Pozisyon)
            .WithMany(p => p.Elemanlar)
            .HasForeignKey(e => e.pozisyon_id)
            .WillCascadeOnDelete(false);



            base.OnModelCreating(modelBuilder);
        }
    }
}
