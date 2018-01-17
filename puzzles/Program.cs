using System;

namespace puzzles
{
    class Program
    {
        
        static void Main()
        {
            // Puzzles
            // The following problems are just continuing practice on all the things we have learned so far.
            Random rand = new Random();
            Console.WriteLine("Hello World!");
            TaskRandomArray(rand);
            TaskCoinFlip(rand);
            TaskNames(rand);
        }

        private static void TaskRandomArray(Random rand)
        {
            // Random Array
            // Create a function called RandomArray() that returns an integer array
            // Place 10 random integer values between 5-25 into the array
            int [] x = RandomArray(rand);
            PrintArray("Random Array with 10 entries: ", x);
            // Print the min and max values of the array
            Console.WriteLine("Minimum Value " + GetMin(x).ToString());
            Console.WriteLine("Maximum Value " + GetMax(x).ToString());
            // Print the sum of all the values
            Console.WriteLine("Sum " + GetSum(x).ToString());
        }

        private static int GetSum(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }

        private static int GetMax(int[] x)
        {
            int max = int.MinValue;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                   max = x[i];
            }
            return max;
        }

        private static int GetMin(int[] x)
        {
            int min = int.MaxValue;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < min)
                   min = x[i];
            }
            return min;
        }

        private static int[] RandomArray(Random rand)
        {
            int [] x = new int [10];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(5, 25);
            }
            return x;
        }

        private static void TaskCoinFlip(Random rand)
        {
            // Coin Flip
            // Create a function called TossCoin() that returns a string

            // Have the function print "Tossing a Coin!"
            // Randomize a coin toss with a result signaling either side of the coin 
            // Have the function print either "Heads" or "Tails"
            // Finally, return the result
            string ret1 = TossCoin(rand);
            // Create another function called TossMultipleCoins(int num) that returns a Double
            double ret2 = TossMultipleCoins(rand, rand.Next(1, 12));
            // Have the function call the tossCoin function multiple times based on num value
            // Have the function return a Double that reflects the ratio of head toss to total toss
            Console.WriteLine("Ratiio " + ret2);
        }

        private static double TossMultipleCoins(Random rand, int num)
        {
            int heads = 0;
            string [] s = new string[num];
            for (int i = 0; i < num; i++)
            {
                s[i] = TossCoin(rand);
                if (s[i] == "Head")
                   ++heads;
            }
            Console.WriteLine("Total Heads " + heads + " out of total " + num);
            return (double) heads/num;
        }

        private  static string TossCoin(Random rand) 
        {
            Console.WriteLine("Tossing a Coin");
            int randomvalue = rand.Next(0,2);
            string ret = "";
            if (randomvalue == 0)
            {
                ret = "Head";
            }
            else
            {
                ret = "Tail";
            }
            Console.WriteLine(ret);
            return ret;
        }



        private  static void TaskNames(Random rand)
        {
            // Names
            // Build a function Names that returns an array of strings

            // Create an array with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            // Shuffle the array and print the values in the new order
            // Return an array that only includes names longer than 5 characters 
            PrintArray("Final array ", Names());
        }

        private static string []  Names ()
        {
            string [] s = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            int n5 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 5)
                   ++n5;
            }

            string [] n = new string [n5];
            for (int i = 0; i < n5; i++)
            {
                if (s[i].Length > 5)
                   n[i] = s[i];
            }
            return n;
        }

        private static void PrintArray(string info, int[] x)
        {
            string strValue = "";
            for (int i = 0; i < x.Length; i++)
            {
                strValue += " " + x[i].ToString();
            }
            Console.WriteLine(info + " [ " + strValue + " ]");
        }

        private static void PrintArray(string info, string[] x)
        {
            string strValue = "";
            for (int i = 0; i < x.Length; i++)
            {
                strValue += " " + x[i];
            }
            Console.WriteLine(info + " [ " + strValue + " ]");
        }
    }
}
