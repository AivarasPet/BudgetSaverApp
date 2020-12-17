namespace BudgetSaverApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTransactions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DboTransaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true), 
                        TransactType = c.Int(nullable: false),
                        Amount = c.Single(nullable: false),
                        Title = c.String(),
                        Category = c.String(),
                        Date = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DboTransaction");
        }
    }
}
