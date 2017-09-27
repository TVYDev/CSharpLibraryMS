namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhotoColumnToLibrariansAndMembersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Librarians", "Photo", c => c.Binary());
            AddColumn("dbo.Members", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Photo");
            DropColumn("dbo.Librarians", "Photo");
        }
    }
}
