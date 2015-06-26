namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EntryPoint
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student("Gosho",    "Peshev",   20, "00001", "+35921234561",  @"konichiwa@abv.bg",        new List<int>() { 2, 2, 4, 6, 5 }, "12"),
                new Student("Ivan",     "Peshev",   24, "00002", "+35921234562",  @"ebasigolemiteryki@abdbg", new List<int>() { 4, 5, 6, 2, 3 }, "12"),
                new Student("Todor",    "Vachev",   22, "00003", "+35921234563",  @"vachev@gmail.com",        new List<int>() { 4, 5, 6, 2, 2 }, "12"),
                new Student("Daniela",  "Koleva",   21, "00004", "+359881234563", @"danito@abvdg",            new List<int>() { 3, 3, 3, 4, 5 }, "13"),
                new Student("Ivanka",   "Gosheva",  27, "00005", "+359881234564", @"i.gosheva@abvg",          new List<int>() { 4, 4, 4, 4, 4 }, "13"),
                new Student("Zornica",  "Ivankova", 27, "00006", "+359881234565", @"zori@gmail.com",          new List<int>() { 6, 5, 4, 3, 2 }, "13"),
                new Student("Tonislav", "Aeorgiev", 20, "00007", "+359881234566", @"slav@abdsbg",             new List<int>() { 4, 5, 6, 2, 2 }, "13")
            };

            var newStudents =
                from s in students
                where s.FirstName.CompareTo(s.LastName) < 0
                select s;

            var youngStudents =
                from s in students
                where s.Age >= 18 && s.Age <= 24
                select s;

            var sortedStudents = students.OrderBy(s => s.FirstName)
                                         .ThenBy(s => s.LastName);

            var studentsFromSameGroup = students.Where(s => s.GroupNumber == "12")
                                           .OrderBy(s => s.FirstName);

            var abvStudents = students.Where(s => s.Email.Contains(@"@abv.bg"));

            var sofiaStudents = students.Where(s => s.PhoneNumber.StartsWith("+3592"));

            var excellentStudents = students.Where(s => s.Marks.Contains(6))
                                            .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks });

            var poorStudents = students.Where(s => s.Marks.GroupBy(r => r).Any(g => g.Count(a => a == 2) > 1));

        }
    }
}
