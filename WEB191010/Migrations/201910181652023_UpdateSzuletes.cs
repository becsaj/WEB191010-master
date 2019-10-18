namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSzuletes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Ugyfels SET Szuletes = '2000-01-01' WHERE id = 1 ");
            Sql("UPDATE Ugyfels SET Szuletes = '2001-02-03' WHERE id = 2 ");
            Sql("UPDATE Ugyfels SET Szuletes = '2002-03-04' WHERE id = 3 ");
        }
        
        public override void Down()
        {
        }
    }
}
