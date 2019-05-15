using CyberPet.Business.Logic.Models;
using System;


namespace CyberPet.Business.Logic
{
    public class Program
    {
        public CyberPetStatus pet = new CyberPetStatus();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is the name of your pet?");
            Console.ResetColor();


            string petName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Pet name is {petName} ");
            Console.ResetColor();
            Console.ReadLine();

            while (true)
            {

                Console.WriteLine("Would you like to play, feed, let them sleep or Quit");
                Console.ReadLine();

                var input = Console.ReadLine();

                switch (input)
                {
                    case "play":
                        Console.WriteLine($"{petName} has been fed");
                        break;
                    case "sleep":
                        Console.WriteLine($"{petName} has sleeping");
                        break;
                    case "eat":
                        Console.WriteLine($"{petName} has enjoyed his food");
                        break;
                    default:
                            break;
                }


            }
        }

    }
}


