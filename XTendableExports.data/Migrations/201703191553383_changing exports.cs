namespace XTendableExports.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingexports : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exports", "Name", c => c.String());
            AddColumn("dbo.Exports", "FileNameFormat", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exports", "FileNameFormat");
            DropColumn("dbo.Exports", "Name");
        }
    }
}
