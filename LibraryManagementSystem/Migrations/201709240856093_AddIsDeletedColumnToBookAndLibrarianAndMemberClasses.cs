namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDeletedColumnToBookAndLibrarianAndMemberClasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Librarians", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "IsDeleted");
            DropColumn("dbo.Librarians", "IsDeleted");
            DropColumn("dbo.Books", "IsDeleted");
        }
    }
}
