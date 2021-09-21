namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedJobAdvertisementStatus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.JobAdvertisements", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JobAdvertisements", "Status", c => c.Boolean(nullable: false));
        }
    }
}
