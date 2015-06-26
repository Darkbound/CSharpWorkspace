namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Class
    {
        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
        }

        public List<Teacher> Teachers { get; set; }

        public Student Student { get; set; }

        public string TextIdentifier { get; private set; }
    }
}
