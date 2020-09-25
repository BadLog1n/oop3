namespace ооп3
{
    internal class Degree
    {
        public string name;
        public int courseCount;
        public string courses;
        public Degree(string n)
        {
            name = n;

        }
        public void AddCourse(Course c)
        {
            courseCount++;
            courses += c.name + " ";
        }

    }
}



