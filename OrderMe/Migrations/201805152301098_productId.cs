namespace OrderMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "Product_SKU", "dbo.Products");
            DropIndex("dbo.OrderDetails", new[] { "Product_SKU" });
            RenameColumn(table: "dbo.OrderDetails", name: "Product_SKU", newName: "Product_ProductId");
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Products", "ProductId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.OrderDetails", "Product_ProductId", c => c.Int());
            AlterColumn("dbo.Products", "SKU", c => c.String());
            AddPrimaryKey("dbo.Products", "ProductId");
            CreateIndex("dbo.OrderDetails", "Product_ProductId");
            AddForeignKey("dbo.OrderDetails", "Product_ProductId", "dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.OrderDetails", new[] { "Product_ProductId" });
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "SKU", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.OrderDetails", "Product_ProductId", c => c.String(maxLength: 128));
            DropColumn("dbo.Products", "ProductId");
            AddPrimaryKey("dbo.Products", "SKU");
            RenameColumn(table: "dbo.OrderDetails", name: "Product_ProductId", newName: "Product_SKU");
            CreateIndex("dbo.OrderDetails", "Product_SKU");
            AddForeignKey("dbo.OrderDetails", "Product_SKU", "dbo.Products", "SKU");
        }
    }
}
