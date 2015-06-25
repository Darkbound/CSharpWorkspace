namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        public List<Disciplines> Disciplines { get; set; }
        public string Name { get; set; }
    }
}
