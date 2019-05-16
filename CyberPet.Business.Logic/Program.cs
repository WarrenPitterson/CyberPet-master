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
            Console.WriteLine("Welcome to CyberPet, please give your pet a name");
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
                    case "q":
                        Console.WriteLine("Application quitting, Thanks for playing");
                        System.Threading.Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                    case "play":
                        interactions.Play(pet);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{petName} has enjoyed the playtime, Boredom level is {pet.Boredom}\r\n");
                        Console.ResetColor();
                        break;
                    case "sleep":
                        interactions.Sleep(pet);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{petName} is sleeping, Tirdeness level is {pet.Tiredness}\r\n");
                        Console.ResetColor();
                        break;
                    case "eat":
                        interactions.Eat(pet);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{petName} is enjoyed thier food, Hunger level is {pet.Hunger}\r\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please input Either Eat, Sleep or Play");
                        Console.ResetColor();
                        break;
                }

                string petStats = $"Pet name : {petName} \r\nHunger level: {pet.Hunger} \r\nTiredness level: {pet.Tiredness} \r\nBoredom Level: {pet.Boredom} ";
                Console.WriteLine(petStats);

            }

        }
    }
}






//var input = Console.ReadLine();

//for (var i = 1; i < 100; i++)
//{
//    try
//    {
//        if (input == "q")
//        {
//            Console.WriteLine("Application quitting");
//            Environment.Exit(0);
//        }
//        if (input == "play")
//        {
//            interactions.Play(pet);
//            Console.WriteLine($"{petName} has enjoyed the playtime, Boredom level is {pet.Boredom}\r\n");
//        }
//        if (input == "sleep")
//        {
//            interactions.Sleep(pet);
//            Console.WriteLine($"{petName} is sleeping, Tirdeness level is {pet.Tiredness}\r\n");
//        }
//        if (input == "eat")
//        {
//            interactions.Eat(pet);
//            Console.WriteLine($"{petName} is enjoyed thier food, Hunger level is {pet.Hunger}\r\n");
//        }
//        else throw new ArgumentNullException();
//    }
//    catch (ArgumentNullException)
//    {
//        Console.WriteLine("Please enter play, sleep or eat");
//    }

//    finally
//    {
//        //string petStats = $"Pet name : {petName} \r\nHunger level: {pet.Hunger} \r\nTiredness level: {pet.Tiredness} \r\nBoredom Level: {pet.Boredom} ";

//        //Console.WriteLine(petStats);
//    }
//}
