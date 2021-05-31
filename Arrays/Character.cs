using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Arrays
{
    class Character
    {
        private string Name;
        private string Race;
        private ConsoleColor Color;
        private int Level;

        public Character(string charName,string charType, ConsoleColor charColor, int charLevel)
        {
            Name = charName;
            Race = charType;
            Color = charColor;
            Level = charLevel;
        }

        public void DisplayInfo()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine($" > {Name} < ");
            WriteLine($"Level : {Level}");
            WriteLine($"Type : {Race}");
            ForegroundColor = prevColor;
        }
    }
}
