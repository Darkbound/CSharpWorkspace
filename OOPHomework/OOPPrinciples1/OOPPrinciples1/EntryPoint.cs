namespace SchoolSystem
{
    using System.Collections.Generic;

    public class EntryPoint
    {
        static void Main()
        {
            Class newClass = new Class("101");

            Student student = new Student("10001", "Pesho");

            Teacher mathTeacher = new Teacher("Herman");
            Teacher physicsTeacher = new Teacher("Albert");
            Teacher csTeacher = new Teacher("Alan");
            Teacher ultimateTeacher = new Teacher("Godzilla");

            newClass.Student = student;
            newClass.Teachers = new List<Teacher>
            {
                mathTeacher,
                physicsTeacher
            };

            student.DisciplinesToStudy = new List<Disciplines>
            {
                new Disciplines("Math", 20, 10, Discipline.Math),
                new Disciplines("Physics", 30, 15, Discipline.Physics),
                new Disciplines("Computer Science", 10, 10, Discipline.ComputerScience)
            };

            mathTeacher.DisciplinesToTeach = new List<Disciplines>
            {
                new Disciplines("Math", 20, 10, Discipline.Math)
            };

            physicsTeacher.DisciplinesToTeach = new List<Disciplines>
            {
                new Disciplines("Physics", 30, 15, Discipline.Physics)
            };

            csTeacher.DisciplinesToTeach = new List<Disciplines>
            {
                new Disciplines("Computer Science", 10, 10, Discipline.ComputerScience)
            };

            ultimateTeacher.DisciplinesToTeach = new List<Disciplines>
            {
                new Disciplines("Math", 20, 10, Discipline.Math),
                new Disciplines("Physics", 30, 15, Discipline.Physics),
                new Disciplines("Computer Science", 10, 10, Discipline.ComputerScience)
            };
        }
    }
}
