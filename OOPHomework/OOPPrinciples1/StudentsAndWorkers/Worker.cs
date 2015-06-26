namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private const int DEFAULT_WORK_HOURS_PER_DAY = 8;
        private const int DEFAULT_WORK_DAYS = 5;

        public Worker()
            : this(Human.DEFAULT_FIRST_NAME, Human.DEFAULT_LAST_NAME, Worker.DEFAULT_WORK_HOURS_PER_DAY, Worker.DEFAULT_WORK_DAYS)
        {

        }

        public Worker(int workHoursPerDay, int workDays)
            : this(Human.DEFAULT_FIRST_NAME, Human.DEFAULT_LAST_NAME, workHoursPerDay, workDays)
        {

        }

        public Worker(string firstName, string lastName, int workHoursPerDay, int workDays)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDays = workDays;
            this.WeekSalary = this.WorkHoursPerDay * this.WorkDays;
        }

        public int WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; set; }

        public int WorkDays { get; set; }

        public int MoneyPerHour()
        {
            return (this.WeekSalary / this.WorkDays) / this.WorkHoursPerDay;
        }
    }
}
