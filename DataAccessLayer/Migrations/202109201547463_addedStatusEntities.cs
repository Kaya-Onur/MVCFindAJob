namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedStatusEntities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cities", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Companies", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.JobAdvertisements", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Departments", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.EducationStatus", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.ForeignLanguages", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Professions", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.JobTypes", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sectors", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sectors", "Status");
            DropColumn("dbo.JobTypes", "Status");
            DropColumn("dbo.Professions", "Status");
            DropColumn("dbo.ForeignLanguages", "Status");
            DropColumn("dbo.Users", "Status");
            DropColumn("dbo.EducationStatus", "Status");
            DropColumn("dbo.Departments", "Status");
            DropColumn("dbo.JobAdvertisements", "Status");
            DropColumn("dbo.Companies", "Status");
            DropColumn("dbo.Cities", "Status");
            DropColumn("dbo.Admins", "Status");
        }
    }
}
