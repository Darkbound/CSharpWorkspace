namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private const int DEFAULT_GRADE = 0;
        private int grade;
        
        public Student(int grade)
            : this(Human.DEFAULT_FIRST_NAME, Human.DEFAULT_LAST_NAME, grade)
        {

        }

        public Student(string firstName, string lastName)
            : this(firstName, lastName, DEFAULT_GRADE)
        {

        }

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public int Grade 
        { 
            get
            {
                return this.grade;
            }

            set
            {
                this.grade = value;
            }
        }
    }
}
