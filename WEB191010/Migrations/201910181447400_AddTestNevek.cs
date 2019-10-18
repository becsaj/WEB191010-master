namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestNevek : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ugyfels", "ElofizetesTipus_Id", "dbo.ElofizetesTipus");
            DropIndex("dbo.Ugyfels", new[] { "ElofizetesTipus_Id" });
            RenameColumn(table: "dbo.Ugyfels", name: "ElofizetesTipus_Id", newName: "ElofizetesTipusId");
            AlterColumn("dbo.Ugyfels", "ElofizetesTipusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ugyfels", "ElofizetesTipusId");
            AddForeignKey("dbo.Ugyfels", "ElofizetesTipusId", "dbo.ElofizetesTipus", "Id", cascadeDelete: true);

            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Juhász Zoltán', 1, 1);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Lakatos Brendon', 0, 1);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Oláh Kira', 1, 2);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Kirigaya Kazuto', 1, 4);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Mohamed Lee', 0, 3);");
            Sql("INSERT INTO Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipusId) VALUES ('Kolompár Jákob', 1, 3);");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ugyfels", "ElofizetesTipusId", "dbo.ElofizetesTipus");
            DropIndex("dbo.Ugyfels", new[] { "ElofizetesTipusId" });
            AlterColumn("dbo.Ugyfels", "ElofizetesTipusId", c => c.Int());
            RenameColumn(table: "dbo.Ugyfels", name: "ElofizetesTipusId", newName: "ElofizetesTipus_Id");
            CreateIndex("dbo.Ugyfels", "ElofizetesTipus_Id");
            AddForeignKey("dbo.Ugyfels", "ElofizetesTipus_Id", "dbo.ElofizetesTipus", "Id");
        }
    }
}
