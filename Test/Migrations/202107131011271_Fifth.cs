namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fifth : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Books", name: "Author_ID", newName: "CurrentAuthor_ID");
            RenameIndex(table: "dbo.Books", name: "IX_Author_ID", newName: "IX_CurrentAuthor_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Books", name: "IX_CurrentAuthor_ID", newName: "IX_Author_ID");
            RenameColumn(table: "dbo.Books", name: "CurrentAuthor_ID", newName: "Author_ID");
        }
    }
}
