namespace OrderMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productsActiveField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Active");
        }
    }
}
