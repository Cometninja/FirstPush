using System;

namespace gitConsoleTest
{
    class ParentClass
    {
        public int TheNumber;
        public ParentClass(int number)
        {
            TheNumber = number;
        }

        public int GetNumber()
        {
            return TheNumber;
        }
    }
}
