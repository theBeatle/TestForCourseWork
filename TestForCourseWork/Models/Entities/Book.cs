using System;
using System.Collections.Generic;

namespace TestForCourseWork
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public int PagesQuantity { get; set; }


        public virtual Genre Genre { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<Author> Authors { get; set; }

    }
}