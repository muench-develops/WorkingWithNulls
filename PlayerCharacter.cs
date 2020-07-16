using System;
namespace WorkingWithNulls
{

    public class PlayerCharacter
    {
        public string Name { get; set; } // Reference Type
        public int DaysSinceLastLoginWithoutNull { get; set; } // Value Type - Magic number approach
        public DateTimeOffset DateOfBirthWithoutNull { get; set; } // Value Type - Magic number approach
        public int? DaysSinceLastLoginWithNull { get; set; } // Value Type - Nullable approach
        public DateTimeOffset? DateOfBirthWithNull { get; set; } // Value Type - Nullable approach


        public PlayerCharacter()
        {

            DaysSinceLastLoginWithoutNull = -1; //magic number
            DateOfBirthWithoutNull = DateTimeOffset.MinValue; //magic number

            // Default value will be null
            // DaysSinceLastLoginWithNull = null; // nullable
            // DateOfBirthWithNull = null;
        }
    }




}