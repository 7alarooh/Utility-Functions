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
                            PrimeNumberChecker();
                            break;
                        //get Fibonacci Sequence Generator
                        case 3:
                            FibonacciSequenceGenerator();
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
        static int factorialCalculator(int num)
        {
            //to check if number less than 2 
            if (num <= 1) { return 1; }

            //here using call self-function to get result until get num == 1
            return num * factorialCalculator(num - 1);
        }
        static void PrimeNumberChecker()
        {
            Console.WriteLine("Enter the number:");
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out int num1))
            {
                bool isPrime = PrimeNoChecker(num1);
                Console.WriteLine($"The number {num1} is prime: {isPrime}");
            }
            else { Console.WriteLine("The input is not a valid intager ! "); }
        }
        //      Prime Number Checker     //
        static bool PrimeNoChecker(int num)
        {
            double squareRoot = Math.Sqrt(num);
            bool isPrime = true;
            // to check the input value if 0 or 1 because it is not considered
            if (num <= 1) { isPrime = false; }
            //to check if input number 2
            else if (num == 2) { isPrime = true; }
            // to check input number isdivisble by 2, it means it is even
            else if (num % 2 == 0) { isPrime = false; }
            else
            {
                //using looping to get all less than input number until 3
                for (int i = 3; i <= squareRoot; i += 2)
                {
                    //using if statement to check if there not remain 
                    if (num % i == 0) isPrime = false;
                    else { isPrime = true; }
                }
            }
            return isPrime;
        }
        //get Fibonacci Sequence Generator
       static void FibonacciSequenceGenerator()
        {

Console.WriteLine("Enter the number to get Fibonacci Sequence Generator:");
                            string input2 = Console.ReadLine();
                            if (int.TryParse(input2, out int num2))
                            {
                                List<int> fibonacciNumbers = FibonacciSequence(num2);
        Console.WriteLine("Fibonacci Sequence:");
                                foreach (var number in fibonacciNumbers)
                                {
                                    Console.Write(number + " ");
                                }
}
                            else { Console.WriteLine("The input is not a valid intager ! "); }
        }
        //      Fibonacci Sequence Generator     //
        static List<int> FibonacciSequence(int num)
        {
            int num1 = 0, num2 = 1, num3;
            List<int> Fibonacci = new List<int>();

            // 


            if (num <= 0) { return Fibonacci; }
            // to add 0 and 1 in list
            Fibonacci.Add(num1);
            Fibonacci.Add(num2);

            //looping to do mathmetic
            for (int i = 3; i <= num; i++)
            {
                num3 = num1 + num2;
                Fibonacci.Add(num3);
                num1 = num2;
                num2 = num3;

            }
            return Fibonacci;
        }
    }
}
