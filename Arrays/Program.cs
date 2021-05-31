using System;
using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        
            PartySystem myParty = new PartySystem();
            myParty.Run();
            
     
            WriteLine("Press any key to exit ...");
            ReadKey();
        }
    }
}
