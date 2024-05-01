using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectorientatedprogramming
{
    public class Games
    {
        public static void GamesChoice() 
        {
            Console.WriteLine("Which game do you want to play?\n[1]Sevens Out\n[2]Three or More?");
            Console.WriteLine("Or do you want to go to testing [3]? ");
            int usergameChoice = Convert.ToInt32(Console.ReadLine());
            if (usergameChoice == 1 ) 
            {
            Console.WriteLine("You have selected Sevens Out");
            SevensOut sevensOut = new SevensOut();
                int sevensOutScore = sevensOut.SevensOutGame();
                
            }
            if (usergameChoice == 2 ) 
            {
            Console.WriteLine("You have selected Three or more");
            //ThreeOrMore threeOrMore = new ThreeOrMore();
             //   int threeormoreScore = threeOrMore.ThreeOrMoreGame();
            }
            if (usergameChoice == 3 ) 
            {
                Testing.Test();
            
            }
        }
    }
}
