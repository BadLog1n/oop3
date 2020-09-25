using System;

namespace ооп3
{
    internal class Course
    {
        public string name;
        public string students;
        public string teachers;
        public int studentCount;
        public int teachersCount;
        public Course(string n)
        {
            name = n;

        }
        public int StudentCount { get; set; }
        public int TeachersCount { get; set; }
        public void AddStudent(Student s)
        {
            studentCount++;
            students += s.name + " ";
        }
        public void AddTeacher(Teacher t)
        {
            teachersCount++;
            teachers += t.name + " ";
        }
        public void GetInfoSt()
        {
            Console.WriteLine($"Название курса: {name}\n Количество студентов {studentCount} \n Количество учителеq {teachersCount}\n ");
        }
    }
}
