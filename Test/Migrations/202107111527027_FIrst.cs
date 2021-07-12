namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FIrst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 250),
                        Author = c.String(maxLength: 250),
                        ISBN = c.String(maxLength: 250),
                        Available = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Utenti",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Surname = c.String(maxLength: 250),
                        Email = c.String(maxLength: 180),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utenti");
            DropTable("dbo.Books");
        }
    }
}
