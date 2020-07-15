using System;

namespace WorkingWithNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Working with Null Values
            //Demonstration with magic numbers 
            //Magic numbers should be avoided
            var player1 = new PlayerCharacter();
            player1.Name = "Max";
            PlayerDisplayer.displayPlayerStats(player1);
            Console.ReadLine();

            var player2 = new PlayerCharacter();
            player2.Name = "Sarah";
            player2.DaysSinceLastLogin = 2;
            PlayerDisplayer.displayPlayerStats(player2);
            Console.ReadLine();

        }
    }
}
