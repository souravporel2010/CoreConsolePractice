using System;

namespace CoreConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counter Value- "+ StaticTest.counter);
        }

    }

    class StaticTest
    {
        public static int counter;
    }
}
