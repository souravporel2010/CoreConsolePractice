using System;

namespace CoreConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("static Counter Value- "+ StaticTest.counter);
            Console.WriteLine("test");
            Console.ReadLine();
            
        }

    }

    class StaticTest
    {
        public static int counter;
    }
}
