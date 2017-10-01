namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsReturnedColumnToBorrowingTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Borrowings", "IsReturned", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Borrowings", "IsReturned");
        }
    }
}
