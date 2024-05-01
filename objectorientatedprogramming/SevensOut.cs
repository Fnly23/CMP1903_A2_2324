using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectorientatedprogramming
{
    internal class SevensOut
    {
        private Random rng;
        public Die Die1;
        public Die Die2;
        public Die Die3;
        public Die Die4;
        int SumOfDice;
        
        public SevensOut() 
        {
        rng = new Random();
        Die1 = new Die(rng);
        Die2 = new Die(rng);
        Die3 = new Die(rng);
        Die4 = new Die(rng);

        

        }
        int player1score = 0;
        int player2score = 0;
        public int player1counter = 0;
        public int player2counter = 0;
        public int SevensOutGame() 
        {
            Console.WriteLine("Welcome to Sevens out! \n Do you want to play against AI[1] or a player 2?[2]");
            int userPlayer2orAI = Convert.ToInt32(Console.ReadLine());
            if (userPlayer2orAI == 1) 
            {

                Console.WriteLine("You selected to play against AI. You are player 1.");
                Console.WriteLine("Rolling the dice for player 1");

                while (true)
                {


                    int SumOfDice = 0;
                    int counter = 0;
                    Console.ReadKey();
                    SumOfDice += Die1.RollTheDice();

                    SumOfDice += Die2.RollTheDice();
                    Console.WriteLine("The dice you rolled were: ");
                    Console.WriteLine(Die1.DiceCurrentValue);
                    Console.WriteLine(Die2.DiceCurrentValue);
                    counter += Die1.RollTheDice();
                    counter += Die2.RollTheDice();

                    if (SumOfDice == 7)
                    {
                        Console.WriteLine("You got 7");
                        Console.WriteLine("The score was: {0} for player 1", (counter));

                        Console.WriteLine("Now onto player 2");
                        break;
                    }


                }
                Console.WriteLine("Rolling the dice for the AI");
                while (true)
                {

                    int SumOfDice = 0;
                    int counter = 0;
                    
                    SumOfDice += Die3.RollTheDice();

                    SumOfDice += Die4.RollTheDice();
                    Console.WriteLine("The dice you rolled were: ");
                    Console.WriteLine(Die3.DiceCurrentValue);
                    Console.WriteLine(Die4.DiceCurrentValue);
                    counter += Die3.RollTheDice();
                    counter += Die4.RollTheDice();

                    if (SumOfDice == 7)
                    {
                        Console.WriteLine("You win");
                        Console.WriteLine("The score was: {0} ", (counter));
                        break;
                    }
                }


                Console.WriteLine("Thanks for playing.");









            }
            
            if (userPlayer2orAI == 2) 
            {
            Console.WriteLine("You selected to play against a second player. You are player 1.");
            Console.WriteLine("Rolling the dice for player 1");
                   
                while (true)
                {
                    
                    
                    int SumOfDice = 0;
                    int counter = 0;
                    Console.ReadKey();
                    SumOfDice += Die1.RollTheDice();
                    
                    SumOfDice += Die2.RollTheDice();
                    Console.WriteLine("The dice you rolled were: ");
                    Console.WriteLine(Die1.DiceCurrentValue);
                    Console.WriteLine(Die2.DiceCurrentValue);
                    counter += Die1.RollTheDice();
                    counter += Die2.RollTheDice();
                    int player1score = counter;
                    int player1counter = counter;
                    int player1 = SumOfDice;
                    if (SumOfDice == 7)
                    {
                        
                        Console.WriteLine("You got 7");
                        Console.WriteLine("The score was: {0} for player 1", (player1counter));
                        
                        Console.WriteLine("Now onto player 2");
                        break;
                    }


                }
                Console.WriteLine("Rolling the dice for player 2"); 
                while (true)
                {
                   
                    int SumOfDice = 0;
                    int counter = 0;
                    Console.ReadKey();
                    SumOfDice += Die3.RollTheDice();
                   
                    SumOfDice += Die4.RollTheDice();
                    Console.WriteLine("The dice you rolled were: ");
                    Console.WriteLine(Die3.DiceCurrentValue);
                    Console.WriteLine(Die4.DiceCurrentValue);
                    counter += Die3.RollTheDice();
                    counter += Die4.RollTheDice();
                    int player2score = counter;
                    int player2counter = counter;
                    int player2 = SumOfDice;
                    if (SumOfDice == 7)
                    {
                        
                        Console.WriteLine("You reached 7 dice");
                        Console.WriteLine("The score was: {0} ", (player2counter));
                        
                        break;
                    }
                
                }
                if (player1counter == player2counter)
                {
                    Console.WriteLine("Its a tie");
                }
                else if (player1counter > player2counter)
                {
                    Console.WriteLine("Player 2 wins");
                }
                else
                {
                    Console.WriteLine("Player 1 wins");
                }

                Console.WriteLine("Thanks for playing.");
            }
            int sevensOutWinning = 0;
            return SumOfDice;
        }
    
    }
}
