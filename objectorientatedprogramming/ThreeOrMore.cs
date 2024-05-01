using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace objectorientatedprogramming
{
    internal class ThreeOrMore 
    {
        private Random rng;
        public Die Die1;
        public Die Die2;
       
        public ThreeOrMore() 
        {
            rng = new Random();
            Die1 = new Die(rng);
            Die2 = new Die(rng);
           

           

        }
        private void player1rolltheDice()
        {
            Die1.RollTheDice();
            
            

        }
        private void player2rolltheDice()
        {
            Die2.RollTheDice();
        }
        public int ThreeOrMoreGame() 
        {
            Console.WriteLine("Welcome to Three Or More! \n Do you want to play agaisnt AI}[1] or another player [2]?");
            int userPlayer2orAI = Convert.ToInt32(Console.ReadLine());
            if (userPlayer2orAI == 1) 
            {
            Console.WriteLine("You chose: \nPlaying agaisnt AI");
            }
            if (userPlayer2orAI == 2)
            {
                Console.WriteLine("You chose: \nPlaying agaisnt another player");
                Console.WriteLine("Rolling the dice for player 1 now");
                player1rolltheDice();




                player2rolltheDice();
                static void CalculateScore(List<Die> dice)
                {
                    int score = 0;
                    var groupedDice = dice.GroupBy(x => x)
                                    .Where(g => g.Count() > 1)
                                    .Select(g => new { Value = g.Key, Count = g.Count() });



                }

            }
            return 0; 
        }   
    }


}




