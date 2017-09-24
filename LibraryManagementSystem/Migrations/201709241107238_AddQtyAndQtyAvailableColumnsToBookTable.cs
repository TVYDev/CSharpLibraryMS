namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQtyAndQtyAvailableColumnsToBookTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Qty", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "QtyAvailable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "QtyAvailable");
            DropColumn("dbo.Books", "Qty");
        }
    }
}
