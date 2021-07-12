namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "CurrentUser_ID", c => c.Int());
            CreateIndex("dbo.Books", "CurrentUser_ID");
            AddForeignKey("dbo.Books", "CurrentUser_ID", "dbo.Utenti", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CurrentUser_ID", "dbo.Utenti");
            DropIndex("dbo.Books", new[] { "CurrentUser_ID" });
            DropColumn("dbo.Books", "CurrentUser_ID");
        }
    }
}
