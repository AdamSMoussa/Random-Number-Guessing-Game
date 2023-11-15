using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumAdamM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();
            int randomNum = random.Next(1, 101);


            Console.WriteLine(" Adam Moussas's Personal Project Guessing Game");
            Console.WriteLine(" A number betweem 1-100 will be generated");
            Console.WriteLine("If you guess the correct number, you will win the game");



            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high.");

                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }


            Console.WriteLine("Congratulations, you have won the game!");

            Console.ReadKey();




        }






    }
}
        
    

