namespace Students
{
    using System.Collections.Generic;
    
    public class Student
    {
        public Student(string firstName, string lastName, int age, string facultyNumber, string phoneNumber, string email, List<int> marks, string groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public string GroupNumber { get; set; }
    }
}
