namespace LocalVariablesExample.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Body = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostComments",
                c => new
                    {
                        Post_Id = c.Int(nullable: false),
                        Comment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_Id, t.Comment_Id })
                .ForeignKey("dbo.Posts", t => t.Post_Id, cascadeDelete: true)
                .ForeignKey("dbo.Comments", t => t.Comment_Id, cascadeDelete: true)
                .Index(t => t.Post_Id)
                .Index(t => t.Comment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostComments", "Comment_Id", "dbo.Comments");
            DropForeignKey("dbo.PostComments", "Post_Id", "dbo.Posts");
            DropIndex("dbo.PostComments", new[] { "Comment_Id" });
            DropIndex("dbo.PostComments", new[] { "Post_Id" });
            DropTable("dbo.PostComments");
            DropTable("dbo.Comments");
        }
    }
}
