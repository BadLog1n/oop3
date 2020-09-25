using System;

namespace ооп3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UProgram program1 = new UProgram("Information Technology");
            Student student1 = new Student("Игорев А. А.");
            Student student2 = new Student("Степанов П. П.");
            Student student3 = new Student("Петрова А. В.");
            Course course1 = new Course("Programming with C#");
            course1.AddStudent(student1);
            course1.AddStudent(student2);
            course1.AddStudent(student3);
            Teacher teacher1 = new Teacher("Иванова Р. Р.");
            Teacher teacher2 = new Teacher("Николаев О. А.");
            course1.AddTeacher(teacher1);
            course1.AddTeacher(teacher2);
            Degree d = new Degree("Bachelor");
            d.AddCourse(course1);
            program1.AddDegree(d);
            program1.GetInfoSt();
            course1.GetInfoSt();
            Console.ReadKey();
        }

    }
}