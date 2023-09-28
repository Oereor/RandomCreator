using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCreator
{
    enum RandomType
    {
        EvenOnly = 0,
        OddOnly = 1
    }

    class RandomCreator
    {
        private readonly Random random = new();

        public int NewRandom(int min, int max)
        {
            return random.Next(min, max);
        }

        public int NewRandom(int min, int max, RandomType type)
        {
            int randNumber;
            do
            {
                randNumber = random.Next(min, max);
            }
            while (randNumber % 2 != (int)type);
            return randNumber;
        }
    }
}
