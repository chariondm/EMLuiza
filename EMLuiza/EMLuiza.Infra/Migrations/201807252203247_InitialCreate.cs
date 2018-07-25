namespace EMLuiza.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employee",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        firstname = c.String(nullable: false, maxLength: 50, unicode: false),
                        lastname = c.String(nullable: false, maxLength: 50, unicode: false),
                        email = c.String(nullable: false, maxLength: 200, unicode: false),
                        department = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.email, unique: true, name: "uk_employee_email");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.employee", "uk_employee_email");
            DropTable("dbo.employee");
        }
    }
}
