namespace EF_Mutiple_Dev_Migration_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitBookTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Book");
        }
    }
}
