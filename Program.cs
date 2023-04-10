using System;

//Namespace
namespace NumberGuesser
{

    //Main class
    class Program{


        //Entry point method
        static void Main(string [] args){


            GetAppInfo(); //Run GetAppInfo function.

            GreetUser();

            while (true){
            //int correctNumber = 8;

            //Creating a new random object

            Random random = new Random();

            int correctNumber = random.Next(1, 10);


            //Init guess var
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while (guess != correctNumber){

                //This is where we get the number but we have to make sure it's a number
                string input = Console.ReadLine();

                //Ensure that it's a number
                if (!int.TryParse(input, out guess)){
                    //Print error message
                    PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                continue;

                }

                //parse the String into an int
                guess = Int32.Parse(input);

                //match the guess to the correct number

                if (guess != correctNumber){
                PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                }
            }
             //Outputting a success message.
                PrintColorMessage(ConsoleColor.Yellow, "You're correct! Congratulations");

                //Ask to play again.
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y"){
                    continue;
                } 
                else if (answer == "N"){
                    return;
                }
                else{
                    return;
                }

            }
        }

        static void GetAppInfo(){
                        //setting the app vars
                    string appName = "Number Guesser";
                    string appVersion = "1.0.0";
                    string appAuthor = "Tyler Balaskovitz";

                    //Change text colr
                    Console.ForegroundColor = ConsoleColor.Green;

                    //Write out app information

                    Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                    Console.ResetColor();

        }

        //Print color message

        static void PrintColorMessage(ConsoleColor color, string message){
             Console.ForegroundColor = color;

                    //tell user its's the wrong number
                Console.WriteLine(message);

                Console.ResetColor();
        }

        static void GreetUser(){
                       //Asking the user's name
            Console.WriteLine("What is your name?");

            //Geting the user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

    }
}