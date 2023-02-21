using System;

namespace gitConsoleTest
{
    class Testing
    {
        public int TheNumber { get; set; }
        public Testing(int number)
        {
            TheNumber = number;
        }

        public int GetNumber()
        {
            return TheNumber;
        }
    }
}
