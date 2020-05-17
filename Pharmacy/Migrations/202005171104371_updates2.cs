namespace Pharmacy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updates2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pharmacists", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Pharmacists", "Firstname", c => c.String(nullable: false));
            AlterColumn("dbo.Pharmacists", "Lastname", c => c.String(nullable: false));
            AlterColumn("dbo.Pharmacists", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pharmacists", "Email", c => c.String());
            AlterColumn("dbo.Pharmacists", "Lastname", c => c.String());
            AlterColumn("dbo.Pharmacists", "Firstname", c => c.String());
            AlterColumn("dbo.Pharmacists", "Password", c => c.String());
        }
    }
}
