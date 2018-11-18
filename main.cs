using System; //using system namespace

namespace MidtermExam_SeedTime //custom namespace
{
    class Program //class name is “Program”
    {
        static void Main(string[] args)
        {
            // these lines of code from “string input;” to “int input_int;” are either declaring a variable, assigning a value to a variable, or a combination of both
            string input;
            string prompt1 = "Type in your favorite number between 1 and 100, and press enter.";
            string prompt2 = "Are you ready to begin?";
            string prompt3 = "Welcome to your personalized fortune teller!";
            int day;
            int selection;
            int input_int;

            Console.WriteLine(prompt3); //next 2 lines are, issuing a command to write the value of prompt 3 and prompt2

            Console.Write(prompt2, '\n');
            input = Console.ReadLine(); //this is reading the response to prompt


            input = input.ToUpper(); //this makes it so that no matter how the word “yes” is spelled, the whole word will be turned into uppercase letters to accept all forms of the word
            if (input == "YES") // if statement, will execute if response is yes
            {
                Console.Write(prompt1, '\n'); 
                input = Console.ReadLine();
                input_int = int.Parse(input);

                DateTime DateCapture; // declares variable “DateCapture
                DateCapture = DateTime.Now; //special c# system object to determine current date and time via pc clock

//assigning values to the days of the week through a switch method
                switch(DateCapture.DayOfWeek) 
                {
                    case DayOfWeek.Sunday:
                        day = 1;
                        break;

                    case DayOfWeek.Tuesday:
                        day = 2;
                        break;
                    
                    //...
                    
                    default:
                        day = 7;
                        break;
                }

Random RandValue = new Random((day + input_int + DateCapture.Month));
                selection = RandValue.Next(1,8); //code to choose a random value between 1 and 7

//depending on the random number selected, equivalent case will be executed
                switch(selection)
                {
                    case 1:
                        Console.Write("Today is Day ");
                        Console.WriteLine(day);
                        Console.WriteLine("It's a bad day to go outside.");
                        break;
                    case 2:
                        Console.WriteLine("Today is Day ");
                        Console.WriteLine(day);
                        Console.WriteLine("It's a good day to go outside.");
                        break;

                        //..

                    default:
                        Console.WriteLine("Today is Day ");
                        Console.WriteLine(day);
                        Console.WriteLine("Things are looking up. Take a risk.");
                        break;
                }
    
            }
            else // if an invalid input is entered, the program will close.
            {
                Environment.Exit(0);
            }

        }
    }
}
