using System;
namespace WorkingWithNulls
{
    public class PlayerDisplayer
    {


        public static void displayPlayerStats(PlayerCharacter character)
        {
            System.Console.WriteLine($"The name of the player is: {character.Name}");

            if (character.DaysSinceLastLogin == -1)
            {
                System.Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                System.Console.WriteLine($"Last login: {character.DaysSinceLastLogin} days ago");
            }

            if (character.DateOfBirth == DateTimeOffset.MinValue)
            {
                System.Console.WriteLine("No value for DateOfBirth");
            }
        }


    }
}