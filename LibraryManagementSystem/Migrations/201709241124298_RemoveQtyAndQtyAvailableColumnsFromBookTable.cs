namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveQtyAndQtyAvailableColumnsFromBookTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Qty");
            DropColumn("dbo.Books", "QtyAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "QtyAvailable", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Qty", c => c.Int(nullable: false));
        }
    }
}
