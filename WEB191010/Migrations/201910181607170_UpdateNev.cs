namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNev : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ElofizetesTipus SET Nev = 'Yesn't' WHERE id = 1");
            Sql("UPDATE ElofizetesTipus SET Nev = 'Havi' WHERE id = 2");
            Sql("UPDATE ElofizetesTipus SET Nev = 'Negyed�ves' WHERE id = 3");
            Sql("UPDATE ElofizetesTipus SET Nev = '�ves' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
