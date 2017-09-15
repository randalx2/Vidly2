namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) " +
                "VALUES (1, 'Hangover', 5, GETDATE(), 2008-06-26, 2");

            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) " +
                "VALUES (2, 'Die Hard', 1, GETDATE(), 1988-07-30, 4");

            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) " +
                "VALUES (3, 'The Terminator', 1, GETDATE(), 1984-03-21, 7");

            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) " +
                "VALUES (4, 'Toy Story', 3, GETDATE(), 1995-12-25, 12");

            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) " +
                "VALUES (5, 'Titanic', 4, GETDATE(), 1997-11-26, 5");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Movies WHERE Id = 1");
            Sql("DELETE FROM Movies WHERE Id = 2");
            Sql("DELETE FROM Movies WHERE Id = 3");
            Sql("DELETE FROM Movies WHERE Id = 4");
            Sql("DELETE FROM Movies WHERE Id = 5");
        }
    }
}
