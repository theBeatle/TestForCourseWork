using System;
using System.Collections.Generic;

namespace TestForCourseWork
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        //Navigation properties
        public virtual Sex Sex { get; set; }
        public virtual Language Language { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}