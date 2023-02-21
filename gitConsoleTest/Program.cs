using System;

namespace gitConsoleTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Still working on adding things into this file");
            var item = new NewTesting(10);
            var parentClass = new ParentClass(20);
            var ServerSideApp = new ServerSideApp();

            parentClass.GetNumber();
            Console.WriteLine($"The first number is {item.GetNumber()} and the second number is {parentClass.GetNumber()}.");
        }
    }
}