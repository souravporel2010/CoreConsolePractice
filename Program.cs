using System;

namespace CoreConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("static Counter Value- "+ StaticTest.counter);
            Console.WriteLine("Hello");
            Console.ReadLine();
            
        }

    }

    class StaticTest
    {
        public static int counter;
    }
}
