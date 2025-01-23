using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Wicher_Road_of_Rodents.Mechanics
{
    internal class Choices
    {
        // Helper method to display choices
        public static void DisplayChoices(params string[] choices)
        {
            Console.WriteLine("\nYour choices:");
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {choices[i]}");
            }
        }
    }
}
