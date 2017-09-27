namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupIdAndCoverColumnsToBookTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "GroupId", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Cover", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Cover");
            DropColumn("dbo.Books", "GroupId");
        }
    }
}
