namespace GeriDonusum2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPozisyonTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pozisyonlars",
                c => new
                    {
                        pozisyon_id = c.Int(nullable: false, identity: true),
                        pozisyon_adi = c.String(),
                    })
                .PrimaryKey(t => t.pozisyon_id);
            
            AddColumn("dbo.Elemanlars", "pozisyon_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Elemanlars", "pozisyon_id");
            AddForeignKey("dbo.Elemanlars", "pozisyon_id", "dbo.Pozisyonlars", "pozisyon_id");
            DropColumn("dbo.Elemanlars", "pozisyon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Elemanlars", "pozisyon", c => c.String());
            DropForeignKey("dbo.Elemanlars", "pozisyon_id", "dbo.Pozisyonlars");
            DropIndex("dbo.Elemanlars", new[] { "pozisyon_id" });
            DropColumn("dbo.Elemanlars", "pozisyon_id");
            DropTable("dbo.Pozisyonlars");
        }
    }
}
