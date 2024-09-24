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
                            GreatestCommonDivisor();
                            break;
                        //to get number into digitals and sum them 
                        case 5:
                            Sum_ofDigits();
                            break;
                        //to get average numbers
                        case 6:
                            ArrayAverage();
                            break;
                        //to count vowel letters in any text
                        case 7:
                            CountVowelsInString();
                            break;
                        //to convert degree of temperature (f>>c) or (c>>f)
                        case 8:
                            TemperatureConverter();
                            break;

                        //to count number of words in any input text 
                        case 9:
                            WordCount();
                            break;

                        //to capitalize the first letter in each word
                        case 10:
                            StringCapitalization();
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
        // to get GCD between two numbers
        static void GreatestCommonDivisor()
        {
                        
                            Console.WriteLine("Enter the First number :");
                            string inPut1 = Console.ReadLine();
        Console.WriteLine("Enter the Secound number :");
                            string inPut2 = Console.ReadLine();
                            if (int.TryParse(inPut1, out int number1) && int.TryParse(inPut2, out int number2))
                            {
                                Console.WriteLine("Greatest Common Divisor:" + FindGCD(number1, number2));
                            }
                            else { Console.WriteLine("The input is not a valid intager ! "); }
}

        //    Greatest Common Divisor (GCD) //
        static int FindGCD(int num1, int num2)
        {
            List<int> result = new List<int>();

            //to know which one is smaller to use in looping to get GCD
            int smallestNo;
            if (num1 > num2) smallestNo = num2;
            else smallestNo = num1;

            for (int i = 1; i < smallestNo; i++)
            {
                //here to check if numbers not remaineder and common between them 
                if (num1 % i == 0 && num2 % i == 0)
                {
                    result.Add(i);
                }

            }
            return result.Max();
        }
        //to get number into digitals and sum them 
        static void Sum_ofDigits()
        {
                Console.WriteLine("Enter the  number :");
                string input3 = Console.ReadLine();

                if (int.TryParse(input3, out int num3))
                {
                    Console.WriteLine($"Sum of Digits:{num3} = " + SumOfDigits(num3));
                }
                else { Console.WriteLine("The input is not a valid intager ! "); }
            }
        //   Sum of Digits           //
        static int SumOfDigits(int num)
        {
            //to conver to can be able to devide it
            string numToString = num.ToString();
            int result = 0;
            foreach (char c in numToString) //here take each char in string
            {
                if (char.IsDigit(c))
                {
                    result += c - '0'; //the char value is not like int number, so using '0'=48, then do '1','2','4' >> result=(49-48)+(50-48)+(52-48)
                }
            }
            return result;
        }
        //to get average numbers
        static void ArrayAverage() {
            Console.WriteLine("Enter the  number of digites :");
            string input4 = Console.ReadLine();
            if (int.TryParse(input4, out int noDigites))
            {

                double[] numArray = new double[noDigites];
                
                int currentIndex = 0;
                while (currentIndex < numArray.Length)
                {
                    Console.Write($"Enter a number {currentIndex + 1}");
                    string inputArr = Console.ReadLine();
                    if (double.TryParse(inputArr, out double resultArr))
                    {
                        numArray[currentIndex] = resultArr;
                        currentIndex++;
                    }
                    else
                    {
                        Console.WriteLine("The input is not a valid number ! ");
                    }

                }
                Console.WriteLine("You've successfullynfilled the array with the following numbers: ");
                foreach (double NUM in numArray) { Console.Write(" " + NUM); }
                Console.WriteLine();

                Console.WriteLine($"the average = " + CalculateAverge(numArray));

            }
            else { Console.WriteLine(" The input is not a valid intager number !"); }

        }
        //     Array Average                     //
        static double CalculateAverge(double[] numbers)
        {
            if (numbers.Length == 0) return 0;
            double sum = 0.0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;

        }

        static void CountVowelsInString() {
            Console.WriteLine("Enter your text:");
            string textToCheck = Console.ReadLine();
            Console.WriteLine("There is/ are : " + toGetNoVowelInText(textToCheck) + " vowel letter/s");
        }
        //     Count Vowels in a String         //
        static int toGetNoVowelInText(string text)
        {
            int textToCheck = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };//put all vowel letters in array
            text = text.ToLower(); // make all text low Case letter

            foreach (char c in text) // take each letter(char) in text 
            {
                if (Array.Exists(vowels, v => v == c)) //to check if char in text is vowel or not by comparing
                {
                    textToCheck++;
                }
            }
            return textToCheck;

        }
        static void TemperatureConverter() {
            Console.WriteLine("converts a temperature: \n 1. from Celsius to Fahrenheit \n 2.from Fahrenheit to Celsius ");
            Console.Write("select to do process : ");
            string inpuT = Console.ReadLine();

            if (int.TryParse(inpuT, out int choose))
            {
                Console.WriteLine("temperature after convert is :" + toConvertTem(choose));
            }
            else { Console.WriteLine("The input is not a valid intager ! "); }
        }
        //  Temperature Converter //
        static double toConvertTem(int choose)
        {
            double result = 0;
            //to do 2 functions in one
            switch (choose)
            {
                case 1:
                    Console.Write("enter  degree of temprature :");
                    double degree = double.Parse(Console.ReadLine());
                    result = degree * 9 / 5 + 32;
                    break;

                case 2:
                    Console.Write("enter  degree of temprature :");
                    double degree1 = double.Parse(Console.ReadLine());
                    result = (degree1 - 32) * 5 / 9;
                    break;

                default:
                    Console.WriteLine("wrong choose!");
                    break;
            }
            return result;

        }
        static void WordCount() {
            Console.WriteLine("Enter your text:");
            string textToCount = Console.ReadLine();
            Console.WriteLine("There is/ are : " + toGetNoWords(textToCount) + " word/s");
        }
        //   Word Count                     //
        static int toGetNoWords(string text)
        {

            int textToCheck = 0;
            if (string.IsNullOrEmpty(text))
                return 0;
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);// to remve blank or space in text to get clear array
            return textToCheck = words.Length;
        }

        static void StringCapitalization()
        {
            Console.WriteLine("Enter your text:");
            string inputText = Console.ReadLine();
            Console.WriteLine(CapitalizeWords(inputText));
        }
        //    String Capitalization             //
        static string CapitalizeWords(string text)
        {

            if (string.IsNullOrEmpty(text)) //to check if not null 
                return text;

            string[] words = text.Split(' '); // to cut long text into words in string array
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0) //if the word not empty value

                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();//here take each word to spilt
                                                                                           //to take the first char to make upper
                                                                                           //and make sure the rest inlowercase

                }
            }
            // Join all the words back into a single string with spaces in between.
            // Assign the result to 'text' and return it.
            return text = string.Join(" ", words);
        }
    }
}
