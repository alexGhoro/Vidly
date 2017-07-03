namespace Vidly.Migrations
{
  using System;
  using System.Data.Entity.Migrations;
    
  public partial class PopulateMovies : DbMigration
  {
    public override void Up()
    {
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, NumberInStock, NumberAvailable ) VALUES('Hangover', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 1, 10, 5)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, NumberInStock, NumberAvailable) VALUES('Die Hard', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 2, 10, 5)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, NumberInStock, NumberAvailable) VALUES('The Terminator', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 5, 10, 5)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, NumberInStock, NumberAvailable) VALUES('Toy Story', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 3, 10, 5)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, NumberInStock, NumberAvailable) VALUES('Titanic', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 4, 10, 5)");
    }
        
    public override void Down()
    {
    }
  }
}
