namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();

            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Goshev", rng.Next(0, 10)),
                new Student("Todor", "Ivanov", rng.Next(0, 10)),
                new Student("Pesho", "Peshev", rng.Next(0, 10)),
                new Student("Chili", "Momchilchov", rng.Next(0, 10)),
                new Student("Ivanka", "Zagorova", rng.Next(0, 10)),
                new Student("Mnogo", "Typo", rng.Next(0, 10)),
                new Student("Da", "Izmislqshipishesh", rng.Next(0, 10)),
                new Student("Imena", "Na", rng.Next(0, 10)),
                new Student("Raka", "Na", rng.Next(0, 10)),
                new Student("Deset", "Studenta", rng.Next(0, 10))
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Trqbva", "Da", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Mojem", "Da", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Pishem", "S", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Misyl", "Kolko", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Po-lesno", "Shteshe", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Da", "Byde", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Naistina", "E", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Mnogo", "Skuchno", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Veche", "Neznam", rng.Next(1, 10), rng.Next(1, 5)),
                new Worker("Kakvo", "DaPisha", rng.Next(1, 10), rng.Next(1, 5))
            };

            students.OrderBy(s => s.Grade);
            workers.OrderByDescending(w => w.MoneyPerHour());

            List<Human> studentsAndWorkers = new List<Human>();

            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            var orderedStudentsAndWorker = studentsAndWorkers.OrderBy(sw => sw.FirstName).ThenBy(sw => sw.LastName);

            foreach (var item in orderedStudentsAndWorker)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }   
        }
    }
}
