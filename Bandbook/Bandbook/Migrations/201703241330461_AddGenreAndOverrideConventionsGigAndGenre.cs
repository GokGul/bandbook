namespace Bandbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreAndOverrideConventionsGigAndGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Artist_Id" });
            AddColumn("dbo.Gigs", "Genre_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gigs", "Place", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gigs", "Artist_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Gigs", "Artist_Id");
            CreateIndex("dbo.Gigs", "Genre_Id");
            AddForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Gigs", "Artist_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Artist_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_Id" });
            DropIndex("dbo.Gigs", new[] { "Artist_Id" });
            AlterColumn("dbo.Gigs", "Artist_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Gigs", "Place", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            DropColumn("dbo.Gigs", "Genre_Id");
            CreateIndex("dbo.Gigs", "Artist_Id");
            AddForeignKey("dbo.Gigs", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
