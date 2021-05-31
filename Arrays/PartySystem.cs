using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Arrays
{
    class PartySystem
    {
        Character[] MyTeam;
        public PartySystem()
        {
            // Construct the team.

            MyTeam = new Character[2] {

                new Character("MaDCrater", "Yellow", ConsoleColor.Yellow, 10),
                new Character("SpingBubbles", "Orc", ConsoleColor.Green, 12)
            };
        }
        public void Run()
        {
            // Display the team.
            Title = "Arrays";
            WriteLine("=== My Characters ===");
            foreach(Character currentCharacter in MyTeam)
            {
                currentCharacter.DisplayInfo();
            }
        }
    }
}
