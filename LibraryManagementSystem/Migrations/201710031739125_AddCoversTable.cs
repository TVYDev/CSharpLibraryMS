namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoversTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "CoverId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "CoverId");
            DropTable("dbo.Covers");
        }
    }
}
