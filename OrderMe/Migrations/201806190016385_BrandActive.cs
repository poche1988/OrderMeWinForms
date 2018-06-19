namespace OrderMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brands", "Active");
        }
    }
}
