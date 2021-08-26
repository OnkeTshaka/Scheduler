namespace Schedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            AddColumn("dbo.Events", "PersonId", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "PersonId");
            AddForeignKey("dbo.Events", "PersonId", "dbo.People", "PersonId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "PersonId", "dbo.People");
            DropIndex("dbo.Events", new[] { "PersonId" });
            DropColumn("dbo.Events", "PersonId");
            DropTable("dbo.People");
        }
    }
}
