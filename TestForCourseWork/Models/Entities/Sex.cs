using System.Collections.Generic;

namespace TestForCourseWork
{
    public class Sex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}