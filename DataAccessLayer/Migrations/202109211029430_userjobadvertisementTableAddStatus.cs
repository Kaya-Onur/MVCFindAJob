namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userjobadvertisementTableAddStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserJobAdvertisements", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserJobAdvertisements", "Status");
        }
    }
}
