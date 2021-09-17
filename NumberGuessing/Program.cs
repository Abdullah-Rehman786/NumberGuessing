using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();

            int RightNum = R.Next(0, 100);

            bool correct = false;
            bool parseSuccess = false;
            do
            {
                Console.Write("Enter a number between 1 to 100 ");
                string guessedNum = Console.ReadLine();

                //exception for no input
                while (string.IsNullOrEmpty(guessedNum))
                {
                    Console.WriteLine("Ain't nobody got time for that, guess a number >:|");
                    guessedNum = Console.ReadLine();
                }

                //exception for invalid input
                while (parseSuccess == false)
                {
                    parseSuccess = int.TryParse(guessedNum, out int guess);

                    if (parseSuccess == false)
                    {
                        Console.WriteLine("Only input an integer number please.");
                        guessedNum = Console.ReadLine();
                    }
                } 



                int x = int.Parse(guessedNum);

                if (x == RightNum)
                {
                    Console.WriteLine("shaBAAM You right.");
                    correct = true;
                }
                else if (x > RightNum)
                {
                    Console.WriteLine("Too high.  Try again");
                }
                else if (x < RightNum)
                {
                    Console.WriteLine("Too low. Try again");
                }
                else
                {
                    Console.WriteLine("Nothing to say.");
                }



            } while (correct == false); 

            Console.WriteLine("Games over, go home.");
            Console.WriteLine("Press Enter to exit");

            string choice = Console.ReadLine();
        }
    }
}
