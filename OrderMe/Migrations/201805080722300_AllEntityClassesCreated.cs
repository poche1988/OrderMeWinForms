namespace OrderMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllEntityClassesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Order_OrderId = c.Int(),
                        Product_SKU = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .ForeignKey("dbo.Products", t => t.Product_SKU)
                .Index(t => t.Order_OrderId)
                .Index(t => t.Product_SKU);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Company = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        SKU = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(),
                        Category_ProductCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.SKU)
                .ForeignKey("dbo.ProductCategories", t => t.Category_ProductCategoryId)
                .Index(t => t.Category_ProductCategoryId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand_BrandId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductCategoryId)
                .ForeignKey("dbo.Brands", t => t.Brand_BrandId)
                .Index(t => t.Brand_BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "Product_SKU", "dbo.Products");
            DropForeignKey("dbo.Products", "Category_ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductCategories", "Brand_BrandId", "dbo.Brands");
            DropForeignKey("dbo.OrderDetails", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.ProductCategories", new[] { "Brand_BrandId" });
            DropIndex("dbo.Products", new[] { "Category_ProductCategoryId" });
            DropIndex("dbo.OrderDetails", new[] { "Product_SKU" });
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderId" });
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Brands");
        }
    }
}
