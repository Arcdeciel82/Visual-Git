// Curt Lynch
// 1/19/2023
// Getting into git
// Hello world, with a simple number guessing game.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        private int steve;

        public int getSteve()
        {
            return steve;
        }

        public void setSteve(int i)
        {
            steve = i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World" + 5);
            Console.ReadKey();

            Console.WriteLine("Setting steve to 4");
            Program p = new Program();
            p.setSteve(4);
            Console.WriteLine("Steve is: " + p.getSteve());
            Console.ReadKey();

            Console.WriteLine("Enter lower bound.");
            int lower_bound = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Upper bound.");
            int upper_bound = int.Parse(Console.ReadLine());

            var rand = new Random();
            int randomNum = rand.Next(lower_bound, upper_bound + 1);

            Console.WriteLine("I'm guessing of a number between " + lower_bound + " and " + upper_bound + ".");
            int userGuess = int.Parse(Console.ReadLine());
            while(userGuess != randomNum)
            {
                if(userGuess < randomNum)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                if (userGuess > randomNum)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                userGuess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Yay, it was " + randomNum + "!");
            Console.ReadKey();
        }
    }
}
