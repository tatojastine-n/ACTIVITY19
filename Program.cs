using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretWordGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string secretWord = "open";
            string userGuess;
            bool isCorrect = false;

            do
            {
                Console.Write("Enter your guess: ");
                userGuess = Console.ReadLine();

                if (string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase))
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            } while (!isCorrect);
            Console.WriteLine("Correct!");
        }
    }
}
