using System;

namespace _00Chall
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenue = true;
            while (displayMenue == true)
            {
                displayMenue = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1) Problem 1: Array Max Result");
            Console.WriteLine("2) Problem 2: Leap Year Calculator");
            Console.WriteLine("3) Problem 3: Perfect Sequence");
            Console.WriteLine("4) Problem 4: Sum of Rows");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                ArrayMax();
                return true;
            }
            else if (result == "2")
            {
                LeapYear();
                return true;
            }
            else if (result == "3")
            {
                PerfectSequence();
                return true;
            }
            else if (result == "4")
            {
                SumOfRows();
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void ArrayMax()
        {
            Console.Clear();
            Console.WriteLine("The computer will choose 5 random numbers.");
            Console.WriteLine("Please pick a number between 1 and 10.");
            Console.WriteLine("Your score will be the number you choose times the number of times the computer shooses that number out of 5");
            int choosenNumber = int.Parse(Console.ReadLine());


            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Random myRandom = new Random();
                numbers[i] = myRandom.Next(1, 11);
            }

            int count = 0;

            for (int j = 0; j < 5; j++)
            {
                if (numbers[j] == choosenNumber)
                {
                    count++;
                }
           
            }

            Console.WriteLine("You choose the number {0} which was choosen by the computer {1} time(s) out of 5.  Your score is {2}", choosenNumber, count, choosenNumber * count);
            Console.ReadLine();
            
        }
        private static void LeapYear()
        {
            Console.Clear();
            Console.WriteLine("The computer will determine if a praticular year is a Leap Year.");
            Console.WriteLine("Please enter a year.");
            int year = int.Parse(Console.ReadLine());

            bool leap = false;

            if (year % 400 == 0)
            {
                leap = true;
            } else if ((year % 4 == 0) && (year % 100 != 0))
            {
                leap = true;
            } else
            {
                leap = false;
            }

            if (leap)
            {
                Console.WriteLine("{0} is a Leap Year!", year);
            } else
            {
                Console.WriteLine("{0} is not a Leap Year.", year);
            }
            Console.ReadLine();
        }
        private static void PerfectSequence()
        {

        }
        private static void SumOfRows()
        {

        }
    }
}
