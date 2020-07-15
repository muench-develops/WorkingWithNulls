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
            if (character.DaysSinceLastLoginWithNull == null)
            {
                System.Console.WriteLine("No value for DaysSinceLastLoginWithNull");
            }
            else
            {
                System.Console.WriteLine($"Bday: {character.DateOfBirthWithNull}");
            }
            if (character.DateOfBirthWithNull == null)
            {
                System.Console.WriteLine("No value for DateOfBirthWithNll");
            }
            else
            {
                System.Console.WriteLine($"Bday: {character.DateOfBirthWithNull}");
            }



        }


    }
}