namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nine : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Books", new[] { "CurrentAuthor_ID" });
            CreateIndex("dbo.Books", "CurrentAuthor_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Books", new[] { "CurrentAuthor_Id" });
            CreateIndex("dbo.Books", "CurrentAuthor_ID");
        }
    }
}
