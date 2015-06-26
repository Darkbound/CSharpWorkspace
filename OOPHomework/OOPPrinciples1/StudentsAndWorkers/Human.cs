namespace StudentsAndWorkers
{
    public abstract class Human
    {
        protected const string DEFAULT_FIRST_NAME = "";
        protected const string DEFAULT_LAST_NAME = "";

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
