namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Szuletes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ugyfels", "Szuletes", c => c.DateTime());

        }
        
        public override void Down()
        {
            DropColumn("dbo.Ugyfels", "Szuletes");
        }
    }
}
