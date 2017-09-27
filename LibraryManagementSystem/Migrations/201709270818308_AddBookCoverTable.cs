namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCoverTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookCovers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Cover = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Books", "CoverId", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Cover");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Cover", c => c.Binary());
            DropForeignKey("dbo.BookCovers", "Id", "dbo.Books");
            DropIndex("dbo.BookCovers", new[] { "Id" });
            DropColumn("dbo.Books", "CoverId");
            DropTable("dbo.BookCovers");
        }
    }
}
