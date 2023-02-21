using System;

namespace gitConsoleTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i have now added in all the files for the code so far");

            var item = new Testing(10);

            Console.WriteLine(item.GetNumber());
        }
    }
}