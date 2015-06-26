namespace SchoolSystem
{
    public enum Discipline
    {
        Math,
        Physics,
        ComputerScience,
    }

    public class Disciplines
    {
        public Disciplines(string name, int lectures, int exercises, Discipline discipline)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
            this.Discipline = discipline;
        }

        public string Name { get; private set; }

        public int Lectures { get; private set; }

        public int Exercises { get; private set; }

        public Discipline Discipline { get; private set; }
    }
}
