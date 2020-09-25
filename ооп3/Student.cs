using System;

namespace ооп3
{
    internal class Student
    {
        public static int count;
        public string name;
        public Course course;
        public Student(string n)
        {
            count++;
            name = n;
        }
        public Course Course
        {
            get => course;
            set
            {
                course = value;
                course.studentCount++;
            }
        }
        public Student(string nm, Course cour)
        {
            count++;
            name = nm;
            course = cour;
            cour.studentCount++;
        }
        public static void CountInfoSt()
        {
            Console.WriteLine($"Количество студентов: {count}");
        }
        public void GetInfoSt()
        {
            Console.WriteLine($"Имя: {name} \nКурс: {course}");
        }
    }
}
