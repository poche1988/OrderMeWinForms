namespace OrderMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierAndCommentInOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Comment", c => c.String());
            AddColumn("dbo.Orders", "Supplier_SupplierId", c => c.Int());
            CreateIndex("dbo.Orders", "Supplier_SupplierId");
            AddForeignKey("dbo.Orders", "Supplier_SupplierId", "dbo.Suppliers", "SupplierId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Supplier_SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Orders", new[] { "Supplier_SupplierId" });
            DropColumn("dbo.Orders", "Supplier_SupplierId");
            DropColumn("dbo.Orders", "Comment");
        }
    }
}
