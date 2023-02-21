using System;

namespace gitConsoleTest
{
    class NewTesting
    {
        public int TheNumber { get; set; }
        public NewTesting(int number)
        {
            TheNumber = number * 5;
        }

        public int GetNumber()
        {
            return TheNumber;
        }
    }
}
