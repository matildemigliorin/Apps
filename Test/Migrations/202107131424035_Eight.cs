namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Name", c => c.String());
            AddColumn("dbo.Authors", "Surname", c => c.String());
            DropColumn("dbo.Authors", "NameAuth");
            DropColumn("dbo.Authors", "SurnameAuth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "SurnameAuth", c => c.String());
            AddColumn("dbo.Authors", "NameAuth", c => c.String());
            DropColumn("dbo.Authors", "Surname");
            DropColumn("dbo.Authors", "Name");
        }
    }
}
