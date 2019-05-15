using CyberPet.Business.Logic.Models;
using System;


namespace CyberPet.Business.Logic
{
    public class Program
    {
        static void Main(string[] args)
        {

            CyberPetStatus pet = new CyberPetStatus();
            CatCyberPetInteractions interactions = new CatCyberPetInteractions();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is the name of your pet?");
            Console.ResetColor();


            string petName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Would you like to play, eat or let them sleep");
            Console.ResetColor();

            for (var i = 1; i < 100; i++)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "play":
                        interactions.Play(pet);
                        Console.WriteLine($"{petName} has enjoyed the playtime, Boredom level is {pet.Boredom}\r\n");
                        break;
                    case "sleep":
                        interactions.Sleep(pet);
                        Console.WriteLine($"{petName} is sleeping, Tirdeness level is {pet.Tiredness}\r\n");
                        break;
                    case "eat":
                        interactions.Eat(pet);
                        Console.WriteLine($"{petName} is enjoyed thier food, Hunger level is {pet.Hunger}\r\n");
                        break;
                    default:
                        Console.WriteLine("This is the end!!");
                        break;

                }
                string petStats = $"Pet name : {petName} \r\nHunger level: {pet.Hunger} \r\nTiredness level: {pet.Tiredness} \r\nBoredom Level: {pet.Boredom} ";

                Console.WriteLine(petStats);

            }
        }
    }
}


