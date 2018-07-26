namespace EMLuiza.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUK_Email : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.employee", "uk_employee_email");
        }
        
        public override void Down()
        {
            CreateIndex("dbo.employee", "email", unique: true, name: "uk_employee_email");
        }
    }
}
