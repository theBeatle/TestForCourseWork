using System.Collections.Generic;
using System.Data.Entity;

namespace TestForCourseWork
{
    internal class CustomSuperPuperInitializer<T> : DropCreateDatabaseAlways<LibraryDb>
    {
        protected override void Seed(LibraryDb context)
        {
            var genre = new Genre
            {
                Name = "SciFi",
                Description = "Scince " +
                "Fiction. Fiction based on imagined future scientific or technological " +
                "advances and major social or environmental " +
                "changes, frequently portraying space or time travel and " +
                "life on other planets"
            };
            context.Genres.Add(genre);
            var language = new Language { Name = "English" };

            context.Authors.Add(new Author
            {
                Name = "Douglas Adams",
                 Country = new Country { Name = "England" },
                  BirthDate = new System.DateTime(1952, 3, 11),
                  DeathDate = new System.DateTime(2001, 4, 11),
                   Sex= new Sex { Name = "Male" },
                    Books = new List<Book> {
                        new Book {
                            Genre = genre,
                            Language = language,
                            PagesQuantity = 1000,
                            PublishDate = new System.DateTime(1979,1,1 ),
                            Title = "The Restaurant at the End of The Universe"
                        },
                        new Book {
                            Genre = genre,
                            Language = language,
                            PagesQuantity = 200,
                            PublishDate = new System.DateTime(1979,1,1 ),
                            Title = "SQL in 45 minutes"
                        }
                    }
            });

            context.SaveChanges();

        }
    }
}