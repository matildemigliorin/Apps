namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seventh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "NameAuth", c => c.String());
            AddColumn("dbo.Authors", "SurnameAuth", c => c.String());
            DropColumn("dbo.Authors", "Name");
            DropColumn("dbo.Authors", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "Surname", c => c.String());
            AddColumn("dbo.Authors", "Name", c => c.String());
            DropColumn("dbo.Authors", "SurnameAuth");
            DropColumn("dbo.Authors", "NameAuth");
        }
    }
}
