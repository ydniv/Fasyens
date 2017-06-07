namespace FasyensDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingpertamasendiri : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fasyen",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fasyen");
        }
    }
}
