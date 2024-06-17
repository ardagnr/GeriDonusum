using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeriDonusum2.Models
{
    public class Kullanicilars
    {
        [Key]
        public int kullanici_id { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string olusturma_tarihi { get; set; }
        public string telefon_numarasi { get; set; }

        public virtual ICollection<Kullanicilar_urunler> KullaniciUrunler { get; set; }
    }

    public class Urunlers
    {
        [Key]
        public int urun_id { get; set; }
        public string urun_turu { get; set; }
        public int satis_fiyat { get; set; }
        public int geridonusum_fiyati { get; set; }
        public virtual ICollection<Kullanicilar_urunler> KullaniciUrunler { get; set; }
    }

    public class Sehirlers
    {
        [Key]
        public int sehir_id { get; set; }
        public string sehir_adi { get; set; }
        public virtual ICollection<Kullanicilar_urunler> KullaniciUrunler { get; set; }
    }

    public class Ilces
    {
        [Key]
        public int ilce_id { get; set; }
        public string ilce_adi { get; set; }
        public virtual ICollection<Kullanicilar_urunler> KullaniciUrunler { get; set; }
    }

    public class Sirketler
    {
        [Key]
        public int sirket_id { get; set; }
        public string sirket_adi { get; set; }
        public string adres { get; set; }

        public virtual ICollection<Elemanlar> Elemanlar { get; set; }
    }

    public class Elemanlar
    {
        [Key]
        public int eleman_id { get; set; }
        public string eleman_adi { get; set; }
        public string pozisyon { get; set; }
        public int sirket_id { get; set; }
        public string eleman_telefon { get; set; }
        public string sifre { get; set; }

        public virtual Sirketler Sirketler { get; set; }
    }

    public class Kullanicilar_urunler
    {
        [Key]
        [Column(Order = 1)]
        public int kullanici_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public int urun_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public int sehir_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public int ilce_id { get; set; }

        public int miktar { get; set; }

        public virtual Kullanicilars Kullanicilar { get; set; }
        public virtual Urunlers Urunler { get; set; }
        public virtual Sehirlers Sehirler { get; set; }
        public virtual Ilces Ilce { get; set; }
    }

    public class GeriDonusumContext : DbContext
    {
        public GeriDonusumContext() : base("name=GeriDonusum2")
        {
        }

        public DbSet<Kullanicilars> Kullanicilar { get; set; }
        public DbSet<Urunlers> Urunler { get; set; }
        public DbSet<Sehirlers> Sehirler { get; set; }
        public DbSet<Ilces> Ilce { get; set; }
        public DbSet<Sirketler> Sirketler { get; set; }
        public DbSet<Elemanlar> Elemanlar { get; set; }
        public DbSet<Kullanicilar_urunler> Kullanicilar_urunler { get; set; }

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

            base.OnModelCreating(modelBuilder);
        }
    }
}
