namespace OrderMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderstate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderStatus");
        }
    }
}
