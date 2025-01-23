using System;
using System.Threading;
using The_Wicher_Road_of_Rodents.Routes;

class Program
{
    // Constants for game configuration
    private const int INITIAL_PLAYER_HEALTH = 100;
    private const int INITIAL_RODENT_HEALTH = 25;
    private const int INITIAL_RODENT_COUNT = 4;

    // Helper method to display text with a typing effect
    private static void TypeText(string text, int delay = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    // Helper method to display choices
    private static void DisplayChoices(params string[] choices)
    {
        Console.WriteLine("\nYour choices:");
        for (int i = 0; i < choices.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {choices[i]}");
        }
    }

    static void Main()
    {
        TypeText("One faithful night, in a village far in the mountain, " +
            "a witcher named Wicher was laying to rest. "); 
          TypeText("Unbeknownst to him, evil was lurking in the shadows, waiting to strike.");

        TypeText("A screech is heard, Wicher is wide awake as he hears a woman screaming for her life. \"They're everywhere!\" she exclaims.");

        TypeText("As he runs out, he sees what she's on about: an army of white hamsters come barreling in. " +
            "Wicher looks confused until he sees what's between the hamsters.");

        TypeText("Between the hamsters, bones and body parts are seen. People flee, chaos rises, and this quiet, dark little town is turning to flame.");

        TypeText("What do you do?", 20);

        DisplayChoices(
            "Run towards the hamsters and fight",
            "Flee the town and leave the hamsters to their own devices"
        );

        while (true)
        {
            string pathChoice = Console.ReadLine()?.Trim();
            var teleport2 = new Teleport2();

            switch (pathChoice)
            {
                case "1":
                    FightHamsters();
                    return;

                case "2":
                    HandleFleePath(teleport2);
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }
    }

    private static void HandleFleePath(Teleport2 teleport2)
    {
        TypeText("As you see all the rodents crawl in, your eyes are filled with fear. " +
                "Trembling on your legs and unable to do something about it, you flee into the woods.");

        TypeText("In the woods you run and run, running for your life. Suddenly you stop in your tracks, you see a portal.");
        TypeText("What do you do?");

        DisplayChoices(
            "Walk into the portal",
            "Turn away from the portal"
        );

        while (true)
        {
            string fleeChoice = Console.ReadLine()?.Trim();

            switch (fleeChoice)
            {
                case "1":
                    TypeText("You walk into the portal, frightened but determined to find out what's on the other side.");
                    teleport2.Run();
                    return;

                case "2":
                    TypeText("You turn away from the portal. As you get ready to run, you feel a draft along your feet. " +
                        "A sudden pull puts the distance between you and the portal to a minimum. It sucks you in.");
                    teleport2.Run();
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }
    }

    static void FightHamsters()
    {
        var teleport1 = new Teleport1();
        int playerHealth = INITIAL_PLAYER_HEALTH;
        int rodentHealth = INITIAL_RODENT_HEALTH;
        int numberOfRodents = INITIAL_RODENT_COUNT;
        Random random = new Random();

        Console.WriteLine("\nPrepare for battle!");
        Thread.Sleep(1000);

        while (numberOfRodents > 0 && playerHealth > 0)
        {
            Console.WriteLine($"\nYour Health: {playerHealth} | Rodents remaining: {numberOfRodents} | Current Rodent Health: {rodentHealth}");
            DisplayChoices("Attack", "Defend");

            string battleChoice = Console.ReadLine()?.Trim();

            if (battleChoice == "1")
            {
                int damage = random.Next(10, 20);
                rodentHealth -= damage;
                TypeText($"You attack the rodent and deal {damage} damage!");

                if (rodentHealth <= 0)
                {
                    numberOfRodents--;
                    rodentHealth = INITIAL_RODENT_HEALTH;
                    TypeText("You defeated a rodent!", 20);
                    Thread.Sleep(500);
                }
            }
            else if (battleChoice == "2")
            {
                TypeText("You brace yourself for the rodent's attack...");
                int rodentDamage = random.Next(5, 15) / 2;
                playerHealth -= rodentDamage;
                TypeText($"The rodent attacks you and deals {rodentDamage} damage! Your health: {playerHealth}");
                continue;
            }
            else
            {
                TypeText("Invalid choice. The rodent takes advantage of your hesitation!");
            }

            if (numberOfRodents > 0)
            {
                int rodentAttack = random.Next(5, 15);
                playerHealth -= rodentAttack;
                TypeText($"The rodent attacks you and deals {rodentAttack} damage!");
            }
        }

        if (playerHealth > 0)
        {
            TypeText("Victory! You have defeated all the rodents!");
            Thread.Sleep(1000);
            teleport1.Run();
        }
        else
        {
            TypeText("You have been defeated by the rodents...");
            Thread.Sleep(1000);
        }
    }
}