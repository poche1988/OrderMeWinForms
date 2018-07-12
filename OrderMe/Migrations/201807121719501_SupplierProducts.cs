namespace OrderMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupplierProducts",
                c => new
                    {
                        SupplierProductId = c.Int(nullable: false, identity: true),
                        Product_ProductId = c.Int(),
                        Supplier_SupplierId = c.Int(),
                    })
                .PrimaryKey(t => t.SupplierProductId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_SupplierId)
                .Index(t => t.Product_ProductId)
                .Index(t => t.Supplier_SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierProducts", "Supplier_SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierProducts", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.SupplierProducts", new[] { "Supplier_SupplierId" });
            DropIndex("dbo.SupplierProducts", new[] { "Product_ProductId" });
            DropTable("dbo.SupplierProducts");
        }
    }
}
