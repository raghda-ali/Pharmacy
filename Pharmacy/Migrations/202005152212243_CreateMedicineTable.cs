namespace Pharmacy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMedicineTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        quantity = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicines");
        }
    }
}
