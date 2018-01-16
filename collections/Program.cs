using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Collections Practice
            // We have discussed how array, list, and dictionaries all can be used, but its about time we put some
            // of this knowledge into action. The following things should just be created in a new .NET project
            // and uploaded at the end.

            Collections1();
            Collections2();
            Collections3();
            Collections4();
        }

        private static void Collections1()
        {

            // Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            int[] numArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (var num in numArray)
            {
                Console.WriteLine("Number Value " + num);
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] strArray = { "Tim", "Martin", "Nikki", "Sara"};
            foreach (var str in strArray)
            {
                Console.WriteLine("String Value " + str);
            }

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[10];
            bool boolValue = true;
            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = boolValue;
                boolValue = !boolValue;
            }
            foreach (var val in boolArray)
            {
                Console.WriteLine("Boolean Value " + val);
            }

        }

        private static void Collections2()
        {
            // Multiplication Table
            // With the values 1-10, use code to generate a multiplication table like the one below.
            // Use a multidimensional array to store all values
            int [,] array2D = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array2D[i,j] = (i+1) * (j+1);
                }
            }

            string strRow = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    strRow = strRow + " " + array2D[i, j].ToString().PadLeft(3, ' ');
                }
                Console.WriteLine("[ " + strRow + " ]");
                strRow = "";
            }
        }

        private static void Collections3()
        {

            
            // List of Flavors
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Venilla");
            flavors.Add("Chocolate");
            flavors.Add("Banana");
            flavors.Add("Straberry");
            flavors.Add("Blueberry");
            flavors.Add("Tropic");
            flavors.Add("Mint");
            foreach (var flavor in flavors)
            {
                Console.WriteLine("Ice Cream Flavor " + flavor);
            }

            // Output the length of this list after building it
            Console.WriteLine("TOTAL number of Ice Cream Flavors " + flavors.Count);

            // Output the third flavor in the list, then remove this value.
            Console.WriteLine("Third Ice Cream Flavor " + flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("After removing Third Ice Cream Flavor, the flavor at 3rd position is " + flavors[2]);

            // Output the new length of the list (Note it should just be one less~)
            Console.WriteLine("TOTAL number of Ice Cream Flavors now is " + flavors.Count);
        }

        private static void Collections4()
        {
            // List of People
            string[] strArray = { "Tim", "Martin", "Nikki", "Sara"};
            // List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Venilla");
            flavors.Add("Chocolate");
            flavors.Add("Banana");
            flavors.Add("Straberry");
            flavors.Add("Blueberry");
            flavors.Add("Tropic");
            flavors.Add("Mint");

            // User Info Dictionary
            // Create a Dictionary that will store both string keys as well as string values
            Dictionary<string,string> favoriteFlavorProfile = new Dictionary<string,string>();

            Random rand = new Random();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach (var str in strArray)
            {
                favoriteFlavorProfile.Add(str, flavors[rand.Next(0, flavors.Count)]);
            }
            // For each name key, select a random flavor from the flavor list above and store it as the value
            
            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.        }
            foreach (var entry in favoriteFlavorProfile)
            {
                Console.WriteLine("User: " + entry.Key + " - Favorite Flavor: " + entry.Value);
            }
        }

    }
}
