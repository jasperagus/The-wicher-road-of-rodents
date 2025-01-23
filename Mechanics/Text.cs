using System;
using System.Threading;
namespace The_Wicher_Road_of_Rodents.Mechanics
{
    public static class Text
    {
        public static void TypeText(string text, int delay = 50)
        {
            foreach (char c in text)
            {
                Console.Write(c);

                // Check if spacebar is being pressed
                if (Console.KeyAvailable && Console.ReadKey(intercept: true).Key == ConsoleKey.Spacebar)
                {
                    Thread.Sleep(delay / 100); // Much faster when spacebar is pressed
                }
                else
                {
                    Thread.Sleep(delay);
                }
            }
            Console.WriteLine();
        }
    }
}