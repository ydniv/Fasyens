namespace FasyensDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fasyen", "Pengrajin", c => c.String());
            AddColumn("dbo.Fasyen", "Name", c => c.String());
            AddColumn("dbo.Fasyen", "ProductDescription", c => c.String());
            AddColumn("dbo.Fasyen", "PriceBeforeDiscount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Fasyen", "PriceAfterDiscount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Fasyen", "seen", c => c.Int(nullable: false));
            AddColumn("dbo.Fasyen", "CategoryId", c => c.Long(nullable: false));
            AddColumn("dbo.Fasyen", "ImageURL", c => c.Int(nullable: false));
            DropColumn("dbo.Fasyen", "CreatedBy");
            DropColumn("dbo.Fasyen", "CreatedDate");
            DropColumn("dbo.Fasyen", "UpdatedBy");
            DropColumn("dbo.Fasyen", "UpdatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fasyen", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fasyen", "UpdatedBy", c => c.String());
            AddColumn("dbo.Fasyen", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fasyen", "CreatedBy", c => c.String());
            DropColumn("dbo.Fasyen", "ImageURL");
            DropColumn("dbo.Fasyen", "CategoryId");
            DropColumn("dbo.Fasyen", "seen");
            DropColumn("dbo.Fasyen", "PriceAfterDiscount");
            DropColumn("dbo.Fasyen", "PriceBeforeDiscount");
            DropColumn("dbo.Fasyen", "ProductDescription");
            DropColumn("dbo.Fasyen", "Name");
            DropColumn("dbo.Fasyen", "Pengrajin");
        }
    }
}
