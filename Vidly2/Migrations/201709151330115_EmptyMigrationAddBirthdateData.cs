namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigrationAddBirthdateData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1984-09-23' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '1989-10-13' WHERE Id = 2");
        }
        
        public override void Down()
        {
            Sql("UPDATE Customers Set BirthDate = NULL");
        }
    }
}
