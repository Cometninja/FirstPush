using System;
using System.Text.Json;

namespace gitConsoleTest
{
    public class JsonTesting
    {
        public JsonTesting() { }
        static string jsonString;
        static string input;
        public void Main()
        {
            while (true)
            {
                Console.WriteLine("Hello Daniel welcome to practicing Json File Techniques.....\n" +
                    "please select what you would like to do");
                input = Console.ReadLine();

                if (input == "quit") break;
                else if (input == "create Data")
                    CreateData();
            }
        }

        static void CreateData()
        {
            List<Data> _data = new List<Data>();

            _data.Add(new Data()
            {
                Name = "Daniel",
                Age = 30,
                LastName = "Casey"
            });

            jsonString = JsonSerializer.Serialize(_data);
            Console.WriteLine(jsonString);
        }
    }
    public class Data
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
    }
}