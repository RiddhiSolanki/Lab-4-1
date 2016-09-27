using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");

            bool answer = true;

            while (answer)
            {

                Console.WriteLine("Enter an integer that's greater than 0 but less than 10");
                int num01 = int.Parse(Console.ReadLine());
                long factorial = 1;
                for (int i = 1; i <= num01; i++)

                {
                    factorial = factorial * i;
                    Console.WriteLine("The factorial of " + i + " is " + factorial);

                }
                Console.WriteLine("Do you want to continue? (y/n)");
                string con = Console.ReadLine();
                if (con == "y")

                { answer = true; }

                else
                {
                    answer = false;
                    Console.WriteLine("Thank you and Take care");
                }





            }

        }



    }
}

