namespace objectorientatedprogramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome. Do you want to play?");
            Console.WriteLine("[1]Yes \n[2]No");
            int userGame = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen: " + userGame);
            if (userGame == 1) 
            {
                
                Games.GamesChoice();
                Testing.Test();
            }
            if (userGame == 2) 
            {
            Console.ReadKey();
            }
        }
    }
}
