namespace GeriDonusum2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elemanlars",
                c => new
                    {
                        eleman_id = c.Int(nullable: false, identity: true),
                        eleman_adi = c.String(),
                        pozisyon = c.String(),
                        sirket_id = c.Int(nullable: false),
                        eleman_telefon = c.String(nullable: false),
                        sifre = c.String(),
                    })
                .PrimaryKey(t => t.eleman_id)
                .ForeignKey("dbo.Sirketlers", t => t.sirket_id, cascadeDelete: true)
                .Index(t => t.sirket_id);
            
            CreateTable(
                "dbo.Sirketlers",
                c => new
                    {
                        sirket_id = c.Int(nullable: false, identity: true),
                        sirket_adi = c.String(),
                        adres = c.String(),
                    })
                .PrimaryKey(t => t.sirket_id);
            
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        ilce_id = c.Int(nullable: false, identity: true),
                        ilce_adi = c.String(),
                    })
                .PrimaryKey(t => t.ilce_id);
            
            CreateTable(
                "dbo.Kullanicilar_urunler",
                c => new
                    {
                        kullanici_id = c.Int(nullable: false),
                        urun_id = c.Int(nullable: false),
                        sehir_id = c.Int(nullable: false),
                        ilce_id = c.Int(nullable: false),
                        miktar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.kullanici_id, t.urun_id, t.sehir_id, t.ilce_id })
                .ForeignKey("dbo.Ilces", t => t.ilce_id, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicilars", t => t.kullanici_id, cascadeDelete: true)
                .ForeignKey("dbo.Sehirlers", t => t.sehir_id, cascadeDelete: true)
                .ForeignKey("dbo.Urunlers", t => t.urun_id, cascadeDelete: true)
                .Index(t => t.kullanici_id)
                .Index(t => t.urun_id)
                .Index(t => t.sehir_id)
                .Index(t => t.ilce_id);
            
            CreateTable(
                "dbo.Kullanicilars",
                c => new
                    {
                        kullanici_id = c.Int(nullable: false, identity: true),
                        kullanici_adi = c.String(),
                        sifre = c.String(),
                        email = c.String(),
                        olusturma_tarihi = c.String(),
                        telefon_numarasi = c.String(),
                    })
                .PrimaryKey(t => t.kullanici_id);
            
            CreateTable(
                "dbo.Sehirlers",
                c => new
                    {
                        sehir_id = c.Int(nullable: false, identity: true),
                        sehir_adi = c.String(),
                    })
                .PrimaryKey(t => t.sehir_id);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        urun_id = c.Int(nullable: false, identity: true),
                        urun_turu = c.String(),
                        satis_fiyat = c.Int(nullable: false),
                        geridonusum_fiyati = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.urun_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kullanicilar_urunler", "urun_id", "dbo.Urunlers");
            DropForeignKey("dbo.Kullanicilar_urunler", "sehir_id", "dbo.Sehirlers");
            DropForeignKey("dbo.Kullanicilar_urunler", "kullanici_id", "dbo.Kullanicilars");
            DropForeignKey("dbo.Kullanicilar_urunler", "ilce_id", "dbo.Ilces");
            DropForeignKey("dbo.Elemanlars", "sirket_id", "dbo.Sirketlers");
            DropIndex("dbo.Kullanicilar_urunler", new[] { "ilce_id" });
            DropIndex("dbo.Kullanicilar_urunler", new[] { "sehir_id" });
            DropIndex("dbo.Kullanicilar_urunler", new[] { "urun_id" });
            DropIndex("dbo.Kullanicilar_urunler", new[] { "kullanici_id" });
            DropIndex("dbo.Elemanlars", new[] { "sirket_id" });
            DropTable("dbo.Urunlers");
            DropTable("dbo.Sehirlers");
            DropTable("dbo.Kullanicilars");
            DropTable("dbo.Kullanicilar_urunler");
            DropTable("dbo.Ilces");
            DropTable("dbo.Sirketlers");
            DropTable("dbo.Elemanlars");
        }
    }
}
