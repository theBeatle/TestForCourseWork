using System.Collections.Generic;

namespace TestForCourseWork
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation properties
        public virtual ICollection<Author> Authors { get; set; }

    }
}