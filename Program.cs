using System;

//Namespace
namespace NumberGuesser
{

    //Main class
    class Program{

        //Entry point method
        static void Main(string [] args){

            //setting the app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tyler Balaskovitz";

            //Change text colr
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app information

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Asking the user's name
            Console.WriteLine("What is your name?");

            //Geting the user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            int correctNumber = 8;

            //Init guess var
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while (guess != correctNumber){

                //This is where we get the number but we have to make sure it's a number
                string input = Console.ReadLine();

                //Ensure that it's a number
                if (!int.TryParse(input, out guess)){
                Console.ForegroundColor = ConsoleColor.Red;

                    //tell user its's the wrong number
                Console.WriteLine("It's not a number, please try again");

                Console.ResetColor();

                continue;

                }

                //parse the String into an int
                guess = Int32.Parse(input);

                //match the guess to the correct number

                if (guess != correctNumber){
                    //change the text color
                Console.ForegroundColor = ConsoleColor.Red;

                    //tell user its's the wrong number
                Console.WriteLine("Wrong number, please try again");

                Console.ResetColor();

                }
            }
             //Outputting a success message.
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You are correct");

                Console.ResetColor();
        }
    }

    
}