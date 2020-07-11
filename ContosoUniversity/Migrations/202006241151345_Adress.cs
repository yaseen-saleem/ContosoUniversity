namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Adress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Adress");
        }
    }
}
