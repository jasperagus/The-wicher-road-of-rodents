using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Wicher_Road_of_Rodents.Mechanics;

namespace The_Wicher_Road_of_Rodents.Routes
{
    internal class HowToPlay
    {
        internal static void Run()
        {
            Text.TypeText("In this game, you play as Wicher, a witcher.");
            Text.TypeText("You will be presented with choices that will determine the outcome of the story.");
            Text.TypeText("To make a choice, type the number corresponding to the choice and press Enter.");
            Text.TypeText("Your goal is to defeat the boss and clear the game.");
            Text.TypeText("Good luck, wicher!");
            return;
        }
    }
}
