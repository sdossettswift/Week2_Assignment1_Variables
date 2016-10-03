using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assignment1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = "Hello World";
            int Columbus = 1492;
            bool myPet = false;
            string Today = "10/03/16";
            double Amount = 5.45;
            char letter = 'X';
            Console.WriteLine(Hello);
            Console.WriteLine("Columbus sailed the world in " + Columbus);
            Console.WriteLine("It is " + myPet + " that I have a dog at home.");
            Console.WriteLine("Today is " + Today);
            Console.WriteLine("I spent $" + Amount + " on a cheeseburger.");
            Console.WriteLine(letter + " marks the spot.");
            Console.ReadLine(); 
        }
    }
}
