using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This is a guessing game that I have created in my early stages of learning c#!
//I tried to play around and change text fonts to dictate if the user guessed the correct answer or not
//If you see any areas where I can improved please let me know!!
namespace GuessingNumbers
{
    class Program
    {
        static void Main()
        {
            int randomNumber = new Random().Next(1, 100);
            Console.Write("Please guess a number between 1 and 100: ");
            int trysAllowed = 5;
            int numberOfTries = 0;

            while (true)
            {
              
                int guess = UsersGuess();
                numberOfTries++;
                if (guess == randomNumber)
                {
                   
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your guess was correct!\n\n");
                    Console.WriteLine("If you would like to play again enter 1");
                    Console.WriteLine("If you would like to exit enter 2");
                    Console.WriteLine("");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.Clear();
                        Console.ResetColor();
                        Main();
                    }
                    else if (input == 2)
                    {
                        Environment.Exit(0);
                    }
                  
                    else
                    {

                       Console.WriteLine("Your input was invalid! Please use numbers 1 or 2!");

                        Console.WriteLine("Press 3 to retry!");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        if (input2 == 3)
                        {
                            Console.Clear();
                            Main();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                 
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high");
                }
                if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low");
                }

                if (numberOfTries == trysAllowed)
                {
                    Console.WriteLine($"The number was: {randomNumber}\n\n");
                    Console.WriteLine("If you would like to play again enter 1");
                    Console.Write("If you would like to exit enter 2");
                    Console.WriteLine("");
                    int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 1)
                        {
                            Console.Clear();
                            Main();
                        }
                        else if (input == 2)
                        {
                            Environment.Exit(0);
                        }
                        else
                    {
                        Console.WriteLine("Your input was invalid! Please use numbers 1 or 2!");
                        Console.WriteLine("Press 3 to retry!");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        if(input2 == 3)
                        {
                            Console.Clear();
                            Main();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }

                Console.Write($"You have {trysAllowed - numberOfTries} tries left. Enter another number: ");
            }
        }


        private static int UsersGuess()
        {
            int guess = 0; // Must be initialized to keep the compiler from complaining.
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid guess.");
                UsersGuess();
            }
            return guess;
        }
    }
}
