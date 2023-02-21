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
            var serverSideApp = new ServerSideApp();
            var jsonTesting = new JsonTesting();

            jsonTesting.Main();

        }
    }
}