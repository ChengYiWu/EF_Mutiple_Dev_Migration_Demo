namespace EF_Mutiple_Dev_Migration_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddField1ByDev1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "Field1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "Field1");
        }
    }
}
