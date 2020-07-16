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
            // var player1 = new PlayerCharacter();
            // player1.Name = "Max";
            // PlayerDisplayer.displayPlayerStats(player1);
            // Console.ReadLine();

            // PlayerCharacter player2 = new PlayerCharacter();
            PlayerCharacter player2 = null;
            player2.Name = "Sarah";
            // player2.DaysSinceLastLoginWithoutNull = 2;
            // PlayerDisplayer.displayPlayerStats(player2);

            //Null-coalescing operator
            //Set default value -1 if DaysSinceLastLoginWithNull is null
            // int days = player2.DaysSinceLastLoginWithNull ?? -1;

            //Null-conditional operator
            //Checks if the object referenz is not null and should it be null the value will be set to -1
            int days = player2?.DaysSinceLastLoginWithNull ?? -1;

            System.Console.WriteLine($"{days} since last login");
            Console.ReadLine();


        }
    }
}
