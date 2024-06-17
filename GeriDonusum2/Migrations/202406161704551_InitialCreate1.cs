namespace GeriDonusum2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Elemanlars", "eleman_telefon", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Elemanlars", "eleman_telefon", c => c.Int(nullable: false));
        }
    }
}
