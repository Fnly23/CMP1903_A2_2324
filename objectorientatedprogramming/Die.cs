using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectorientatedprogramming
{
    internal class Die
    {
        private Random RandomNumber;

        public int DiceCurrentValue;
        public Die(Random rng)


        {
            this.RandomNumber = rng;
            DiceCurrentValue = 0;


        }

        public int RollTheDice()
        {


            Random rng = new Random();

            DiceCurrentValue = RandomNumber.Next(1, 7);






            return DiceCurrentValue;


        }
    }
}