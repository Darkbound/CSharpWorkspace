namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        public Teacher()
        {

        }

        public Teacher(string name)
            : this(name, new List<Disciplines> { null })
        {

        }

        public Teacher(string name, List<Disciplines> disciplinesToTeach)
        {
            this.Name = name;
            this.DisciplinesToTeach = disciplinesToTeach;
        }

        public List<Disciplines> DisciplinesToTeach { get; set; }
    }
}
