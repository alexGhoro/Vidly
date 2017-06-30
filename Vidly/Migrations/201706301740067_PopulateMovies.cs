namespace Vidly.Migrations
{
  using System;
  using System.Data.Entity.Migrations;
    
  public partial class PopulateMovies : DbMigration
  {
    public override void Up()
    {
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES('Hangover', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 1)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES('Die Hard', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 2)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES('The Terminator', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 2)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES('Toy Story', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 3)");
      Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES('Titanic', '2001-01-23 00:00:00', '2017-06-30 00:00:00', 4)");
    }
        
    public override void Down()
    {
    }
  }
}
