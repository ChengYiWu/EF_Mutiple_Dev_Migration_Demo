namespace EF_Mutiple_Dev_Migration_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddField2ByDev2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "Field2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "Field2");
        }
    }
}
