using System;

namespace CyberPet.Business.Logic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your pet?");
            string petName = Console.ReadLine();
            Console.WriteLine($"Pet name is {petName} ");
        }


    }

}
