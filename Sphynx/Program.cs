using System;

namespace Sphynx
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Hello Stranger! You're now at the beginning of a dangerous journey." +
            "Are you ready to start?");
            bool notYes = true;
            while (notYes)
            {
                string firstAnswer = Console.ReadLine();
                switch (firstAnswer.ToLower())
                {
                    case "yes":
                        Console.WriteLine("A large door in the rock is opened before you and you did a step inside.");
                        Console.WriteLine("The darkness surrounds and you see only a small plate on the wall in front of you.");
                        Console.WriteLine("It says \"Next you'll have no right for a mistake\"");
                        Console.WriteLine("On reading these lines you feel that something stares at you. What will you do?");
                        notYes = false;
                        break;
                    case "no":
                        Console.WriteLine("Actually, you have no right to choose.");
                        notYes = true;
                        goto case "yes";
                    default:
                        Console.WriteLine("You must choose <yes> or <no>.");
                        break;
                }
            }
            Console.WriteLine("You may <run>, <turn back> or <do nothing>");
            bool notTurn = false;
            while (notTurn)
            {
                string secondAnswer = Console.ReadLine();
                switch (secondAnswer.ToLower())
                {
                    case "run":
                        Console.WriteLine("You started to run from the horrifying stare and suddenly fell to the abyss.");
                        notTurn = true;
                        goto BadEnd;
                    case "do nothing":
                        Console.WriteLine("The darkness swallowed you.");
                        notTurn = true;
                        goto BadEnd;
                    case "turn back":
                        Console.WriteLine("You slowly turned back and saw a giant Sphynx.");
                        notTurn = false;
                        goto MeetSphynx;
                }
            }
        MeetSphynx:
            Console.WriteLine("The time for riddles has come.");
            Console.WriteLine("So, the first one is:");
            Console.WriteLine("I am born of water but when I return to water, I die. What am I?");
            bool notIce = false;
            while (notIce)
            {
                string firstRiddle = Console.ReadLine();
                switch (firstRiddle.ToLower())
                {
                    case "ice":
                        Console.WriteLine("Well done! The next riddle.");
                        notIce = true;
                        break;
                    default:
                        Console.WriteLine("You should think harder. My patience's for you. Try again.");
                        notIce = false;
                        break;
                }
            }
            Console.WriteLine("What gives you the strength and power to walk through a wall?");
            bool notDoor = false;
            while (notDoor)
            {
                string secondRiddle = Console.ReadLine();
                switch (secondRiddle.ToLower())
                {
                    case "door":
                        Console.WriteLine("Well. We're coming to an end.");
                        notDoor = true;
                        break;
                    default:
                        Console.WriteLine("Think harder! My patience is almost out.");
                        notDoor = false;
                        break;
                }
            }
            Console.WriteLine("Now you'll have only one chance. Listen attentively and show your best.");
            Console.WriteLine("Which creature walks on four legs in the morning, two legs in the afternoon, and three legs in the evening?");
            bool notMan = false;
            while (notMan)
            {
                string lastRiddle = Console.ReadLine();
                switch (lastRiddle.ToLower())
                {
                    case "man":
                        Console.WriteLine("Great! For now you'll be rewarded.");
                        notMan = true;
                        break;
                    default:
                        Console.WriteLine("You should think harder. My patience's for you. Try again.");
                        notMan = false;
                        goto PreBadEnd;
                }
            }
        GoodEnd:
            Console.WriteLine("The Spnynx is pleased with your answer.");
            Console.WriteLine("He slowly disappears leaving you a beutiful gem. This is your prize.");
            Console.WriteLine("The rocks has opened, and you see the light. Now you may go home");
            goto Ending;
        PreBadEnd:
            Console.WriteLine("The Spynx looked disappointed with you. The last you saw was the darkness of his abysmal throat.");
        BadEnd:
            Console.WriteLine("Your journey is over. You died.");
        Ending:
            Console.WriteLine("Press <1> to start once again or press any key to quit.");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("Bye.");
            }
        }

    }
}
