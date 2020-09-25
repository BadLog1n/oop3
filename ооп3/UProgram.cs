using System;

namespace ооп3
{
    internal class UProgram
    {
        public string name;
        public string degrees;
        public UProgram(string n)
        {
            name = n;
        }
        public void AddDegree(Degree d)
        {
            degrees += d.name + " ";
        }

        public void GetInfoSt()
        {
            Console.WriteLine($"Название: {name} \nСтепень: {degrees} ");
        }

    }
}
