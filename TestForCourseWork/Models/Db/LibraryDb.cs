namespace TestForCourseWork
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryDb : DbContext
    {
        public LibraryDb()
            : base("name=LibraryDb")
        {
            Database.SetInitializer<LibraryDb>(new CustomSuperPuperInitializer<LibraryDb>());
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Language> Languges { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }

    }
}