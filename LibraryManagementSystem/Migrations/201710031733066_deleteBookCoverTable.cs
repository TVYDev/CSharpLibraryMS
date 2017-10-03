namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteBookCoverTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookCovers", "Id", "dbo.Books");
            DropIndex("dbo.BookCovers", new[] { "Id" });
            DropColumn("dbo.Books", "CoverId");
            DropTable("dbo.BookCovers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookCovers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Cover = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "CoverId", c => c.Int(nullable: false));
            CreateIndex("dbo.BookCovers", "Id");
            AddForeignKey("dbo.BookCovers", "Id", "dbo.Books", "Id");
        }
    }
}
