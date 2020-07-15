using System;
namespace WorkingWithNulls
{

    public class PlayerCharacter
    {
        public string Name { get; set; } // Reference Type
        public int DaysSinceLastLogin { get; set; } // Value Type
        public DateTimeOffset DateOfBirth { get; set; } // Value Type


        public PlayerCharacter()
        {
            DaysSinceLastLogin = -1; //magic number
            DateOfBirth = DateTimeOffset.MinValue; //magic number
        }
    }




}