using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:  ");
            string userName = Console.ReadLine();
            string userContinue;
            
            do
            {
                                     
                Console.WriteLine("Enter a number between 1 and 100: ");
                int userNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("");
               
                if (userNumber < 1 || userNumber > 100)
                {
                    Console.WriteLine("ONLY ENTER NUMBERS BETWEEN 1 AND 100! Please try again...");
                }

                else if (userNumber % 2 != 0)
                {
                    Console.WriteLine(userName + ", " + userNumber + " is odd");
                }

                else if (userNumber % 2 == 0 && userNumber <= 25)
                {
                    Console.WriteLine(userName + ", " + userNumber + " is even and less than 25");
                }

                else if (userNumber % 2 == 0 && userNumber > 25 && userNumber <= 60)
                {
                    Console.WriteLine(userName + ", " + userNumber + " is even");
                }

                else if (userNumber % 2 == 0 && userNumber > 60)
                {
                    Console.WriteLine(userName + ", " + userNumber + " is even");
                }

                else if (userNumber % 2 != 0 && userNumber > 60)
                {
                    Console.WriteLine(userName + ", " + userNumber + " is odd");
                }

                Console.WriteLine("");

                Console.WriteLine("Continue (y/n)? ");
                userContinue = Console.ReadLine();

                Console.WriteLine("");

            } while (userContinue == "y" || userContinue == "Y");

            Console.WriteLine("Bye!");

        }
    }
}
