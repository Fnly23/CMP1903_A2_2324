using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectorientatedprogramming
{
    public class Testing
    {
        public static void Test()
        {


            SevensOut sevensOut = new SevensOut();
            int x = sevensOut.SevensOutGame();
            
            
            Debug.Assert(sevensOut.Die1.DiceCurrentValue > 1 && sevensOut.Die1.DiceCurrentValue < 6, "Dice 1 is out of range");
            Debug.Assert(sevensOut.Die2.DiceCurrentValue > 1 && sevensOut.Die2.DiceCurrentValue < 6, "Dice 2 is out of range");
            Debug.Assert(sevensOut.Die3.DiceCurrentValue > 1 && sevensOut.Die3.DiceCurrentValue < 6, "Dice 3 is out of range");
            Debug.Assert(sevensOut.Die4.DiceCurrentValue > 1 && sevensOut.Die4.DiceCurrentValue < 6, "Dice 4 is out of range");
            // the debug asserting tool is used to find the total value and make sure it is the correct number
            // it assigns the expected total to the values of the total from the game classz
            int player1 = sevensOut.Die1.DiceCurrentValue + sevensOut.Die2.DiceCurrentValue;
            int player2 = sevensOut.Die3.DiceCurrentValue + sevensOut.Die4.DiceCurrentValue;

            Debug.Assert(player1 != 7 && player2 != 7, "The sum of the rolls was displayed incorrectly");
            if (player1 == 7 && player2 ==7) 
            {
            Console.WriteLine("Tests passed successfully.");
            }
            
            

        }
    }
}
