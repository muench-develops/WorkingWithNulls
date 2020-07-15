using System;
namespace WorkingWithNulls
{
    public class PlayerDisplayer
    {


        public static void displayPlayerStats(PlayerCharacter character)
        {
            System.Console.WriteLine($"The name of the player is: {character.Name}");


            //Magic Number approach
            if (character.DaysSinceLastLoginWithoutNull == -1)
            {
                System.Console.WriteLine("No value for DaysSinceLastLoginWithoutNull");
            }
            else
            {
                System.Console.WriteLine($"Last login: {character.DaysSinceLastLoginWithoutNull} days ago");
            }

            if (character.DateOfBirthWithoutNull == DateTimeOffset.MinValue)
            {
                System.Console.WriteLine("No value for DateOfBirthWithoutNull");
            }
            else
            {
                System.Console.WriteLine($"Bday: {character.DateOfBirthWithoutNull}");
            }

            //Nullable approach
            if (character.DaysSinceLastLoginWithNull.HasValue)
            {
                System.Console.WriteLine($"Bday: {character.DateOfBirthWithNull}");
            }
            else
            {
                System.Console.WriteLine("No value for DaysSinceLastLoginWithNull");
            }
            if (character.DateOfBirthWithNull.HasValue)
            {
                System.Console.WriteLine($"Bday: {character.DateOfBirthWithNull}");
            }
            else
            {
                System.Console.WriteLine("No value for DateOfBirthWithNll");
            }



        }


    }
}