using System;

namespace DIKULecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Speaker test = new Speaker("Hans", "Datalog", 45);
            Console.WriteLine(test.GetType().Name);
        }
    }
}
