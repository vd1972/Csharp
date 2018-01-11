using System;

namespace fundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Task 1 
            // Create a Loop that prints all values from 1-255  
            Console.WriteLine("Task 1");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Task 2
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both  
            Console.WriteLine("Task 2");
            for (int i = 1; i <= 20; i++)
            {
                if ((i%3 == 0 || i%5 == 0) && i%15 != 0)
                {
                Console.WriteLine(i);
                }
            }

            // Task 3
            // Modify the previous loop to print "Fizz" for multiples of 3, 
            // "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5 
            Console.WriteLine("Task 3");
            for (int i = 1; i <= 20; i++)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine( "Fizz" );
                }
                if (i%5== 0)
                {
                    Console.WriteLine( "Buzz" );
                }
                if (i%15 == 0)
                {
                    Console.WriteLine( "FizzBuzz" );
                }
            }

            // Task 4
            // (Optional) If you used modulus in the last step, try doing the same without using it.
            // Vice-versa for those who didn't! 
            Console.WriteLine("Task 4");
            for (int i = 1; i <= 20; i++)
            {
                if ((float)i/3- (float) (i/3) == (float) 0)
                {
                    Console.WriteLine( "Fizz "  );
                }
                if  ((float)i/5- (float) (i/5) == (float) 0)
                {
                    Console.WriteLine( "Buzz " );
                }
                if  ((float)i/15- (float) (i/15) == (float) 0)
                {
                    Console.WriteLine( "FizzBuzz "  );
                }
            }

            // Task 5
            // (Optional) Generate 10 random values and output the respective word, in relation to step 
            // three, for the generated values
            Console.WriteLine("Task 5");
            Random rand = new Random();
            for (int var = 1; var <= 10; var++)
            {
                int i = rand.Next(1, 100);
                if (i%15 == 0)
                {
                    Console.WriteLine( "FizzBuzz" );
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine( "Fizz" );
                }
                else if (i%5== 0)
                {
                    Console.WriteLine( "Buzz" );
                }
                else
                {
                    Console.WriteLine( "Neither" );
                }
            }


        }
    }
}
