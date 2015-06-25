namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private const int DEFAULT_WEEK_SALARY = 5;
        private const int DEFAULT_WORK_HOURS_PER_DAY = 8;

        public Worker()
        {
            this.WeekSalary = DEFAULT_WEEK_SALARY;
            this.WorkHoursPerDay = DEFAULT_WORK_HOURS_PER_DAY;
        }

        public Worker(int weekSalary, int workHoursPerDay)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public int MoneyPerHour(int workHoursPerDay, int workDaysPerWeek, int weekSalary)
        {
            return 0;
        }
    }
}
