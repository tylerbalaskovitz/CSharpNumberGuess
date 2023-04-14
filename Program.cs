// Shows you are using the System library in your project. Gives you access to System methods like WriteLine(), ReadLine().
using System;

//Namespace - identifies and encapuslates your code within that namespace. Useful for organizing your code. Similar to packages in Java.
namespace NumberGuesser
{

    //Defines the name of class 
    class Program{


        //Entry point method to your application
        static void Main(string [] args){


            GetAppInfo(); //Runs the GetAppInfo() function, see below.

            GreetUser(); //Runs the GreetUser() function, see below

            while (true){


            //Creating a new random object

            Random random = new Random();

            //Sets the random values in this from 1 to 10. The low is on the left, the high on the right.
            int correctNumber = random.Next(1, 10);


            //Initial variable guess is set to 0.
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not equal to correctNumber
            while (guess != correctNumber){

                //This is where we get the number but we have to make sure it's a number
                string input = Console.ReadLine();

                //Ensure that it's a number, by returning a boolean from the TryParse(), with a String as the input and the output as int32
                if (!int.TryParse(input, out guess)){
                    
                    //Like Java, methods/functions can take ENUMS, Objects, strings, int, etc as values within their paramteers. 
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
                PrintColorMessage(ConsoleColor.Yellow, "You're correct!");

                //Ask to play again.
                Console.WriteLine("Play Again? [Y or N]");

                //Reads the line and shifts the string to uppercase letters via method/function chaining. 
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

                    //Changes the color of the text on the console using the ConsoleColor ENUM.
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