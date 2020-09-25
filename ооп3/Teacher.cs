using System;

namespace ооп3
{
    internal class Teacher
    {
        public string name;
        public Course course;
        public Teacher(string n)
        {
            name = n;
        }
        public Teacher(string n, Course c)
        {
            name = n;
            course = c;
            c.teachersCount++;
            c.teachers += "\n" + n;
        }
        public void GetInfoSt()
        {
            Console.WriteLine($"Имя: {name} \nКурс {course}");
        }
    }
}
