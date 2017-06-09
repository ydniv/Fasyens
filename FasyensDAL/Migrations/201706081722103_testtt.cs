namespace FasyensDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testtt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fasyen", "ImageURL", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fasyen", "ImageURL", c => c.Int(nullable: false));
        }
    }
}
