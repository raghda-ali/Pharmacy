namespace Pharmacy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        medicine_id = c.Int(nullable: false),
                        total_price = c.Double(nullable: false),
                        amount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.medicine_id)
                .ForeignKey("dbo.Medicines", t => t.medicine_id)
                .Index(t => t.medicine_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "medicine_id", "dbo.Medicines");
            DropIndex("dbo.Orders", new[] { "medicine_id" });
            DropTable("dbo.Orders");
        }
    }
}
