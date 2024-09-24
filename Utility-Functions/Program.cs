using System.Reflection.Emit;

namespace Utility_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu() 
        {
            bool exit = false;
            do
            {
                Console.Clear();

                /////To display Main Menu///////
                Console.Write("Main Menu: " +
                    "\n 1. Factorial Calculator " +
                    "\n 2. Prime Number Checker " +
                    "\n 3. Fibonacci Sequence Generator " +
                    "\n 4. Greatest Common Divisor (GCD)  " +
                    "\n");
                Console.WriteLine(" 5.Sum of Digits " +
                    "\n 6.Array Average " +
                    "\n 7.Count Vowels in a String " +
                    "\n 8.Temperature Converter " +
                    "\n 9.Word Count " +
                    "\n 10.String Capitalization " +
                    "\n 11. Exit");

                Console.WriteLine("Choose your option:");
                string EnterChoose = Console.ReadLine();

                if (int.TryParse(EnterChoose, out int operation))
                {
                    ////switch case///

                    switch (operation)
                    {
                        //to get factorial of a number
                        case 1:
                            FactorialCalculator();
                            break;
                        //to check if prime number or not
                        case 2:
                            //PrimeNumberChecker();
                            break;
                        //get Fibonacci Sequence Generator
                        case 3:
                            //FibonacciSequenceGenerator();
                            break;
                        // to get GCD between two numbers
                        case 4:
                            //GreatestCommonDivisor();
                            break;
                        //to get number into digitals and sum them 
                        case 5:
                            //Sum_ofDigits();
                            break;
                        //to get average numbers
                        case 6:
                            //ArrayAverage();
                            break;
                        //to count vowel letters in any text
                        case 7:
                            //TemperatureConverter();
                                break;
                        //to convert degree of temperature (f>>c) or (c>>f)
                        case 8:
                            //TemperatureConverter();
                            break;

                        //to count number of words in any input text 
                        case 9:
                            //WordCount();
                            break;

                        //to capitalize the first letter in each word
                        case 10:
                            //StringCapitalization();
                            break;
                        //Exit
                        case 11:
                            Console.Clear();
                            exit = true;
                            Console.WriteLine("Exiting the program. Goodbye!");
                            break;

                        //if the user enter any number not using
                        default:
                            Console.WriteLine("wrong choose!");
                            break;
                    }
                }
                else { Console.WriteLine("The input is not a valid intager ! "); }

                // to keep programming running
                Console.WriteLine("Do you want to select anther option ? \n choose 1 to (yes) ,and 2 to (no) : ");
                string inputSelect = Console.ReadLine();
                if (int.TryParse(inputSelect, out int selected))
                {
                    if (selected == 1 || selected == 2)
                    {
                        if (selected == 1) { exit = false; }
                        else { exit = true; }
                    }
                    else { Console.WriteLine("you should choose [1] or [2] ! "); }
                }
                else { Console.WriteLine("The input is not a valid intager ! "); }
            }
            while (!exit);
        }

        static void FactorialCalculator() {
            Console.WriteLine("Enter the number:");
            //int num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num) && num >= 0)
            {
                if (num < 20)
                {
                    Console.WriteLine($"the factorial of {num} is " + factorialCalculator(num));
                }
                else { Console.WriteLine("Wroning: The factorial of " + num + " will be a very large number !"); }
            }
            else { Console.WriteLine("The input is not a valid intager ! "); }
        }


    }
}
