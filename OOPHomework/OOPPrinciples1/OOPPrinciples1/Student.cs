namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Student : People
    {
        public Student(string number, string name)
            : this(number, name, new List<Disciplines> { null })
        {

        }

        public Student(string number, string name, List<Disciplines> disciplinesToStudy)
        {
            this.Number = number;
            this.Name = name;
            this.DisciplinesToStudy = disciplinesToStudy;
        }

        public string Number { get; private set; }

        public List<Disciplines> DisciplinesToStudy { get; set; }
    }
}
