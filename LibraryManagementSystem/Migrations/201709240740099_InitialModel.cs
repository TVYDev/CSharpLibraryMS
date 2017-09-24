namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        AuthorName = c.String(nullable: false, maxLength: 255),
                        YearEdition = c.Int(nullable: false),
                        Isbn = c.String(),
                        IsBorrowed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Borrowings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        LibrarianId = c.Int(nullable: false),
                        BorrowDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Librarians", t => t.LibrarianId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.BookId)
                .Index(t => t.LibrarianId);
            
            CreateTable(
                "dbo.Librarians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Address = c.String(nullable: false),
                        DateOfMembership = c.DateTime(nullable: false),
                        MaxBookLimit = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borrowings", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Borrowings", "LibrarianId", "dbo.Librarians");
            DropForeignKey("dbo.Borrowings", "BookId", "dbo.Books");
            DropIndex("dbo.Borrowings", new[] { "LibrarianId" });
            DropIndex("dbo.Borrowings", new[] { "BookId" });
            DropIndex("dbo.Borrowings", new[] { "MemberId" });
            DropTable("dbo.Members");
            DropTable("dbo.Librarians");
            DropTable("dbo.Borrowings");
            DropTable("dbo.Books");
        }
    }
}
