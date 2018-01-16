using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Boxing();
        }

        private static void Boxing()
        {
            // Create an empty List of type object
            List<object> boxedItems = new List<object>();
            //  Add the following values to the list: 7, 28, -1, true, "chair"  
            boxedItems.Add(7);
            boxedItems.Add(28);
            boxedItems.Add(-1);
            boxedItems.Add(true);
            boxedItems.Add( "chair"  );
            // Loop through the list and print all values (Hint: Type Inference might help here!)
            //  Add all values that are Int type together and output the sum
            int sum = 0;
            foreach (var item in boxedItems)
            {
                if (item is string)
                {
                    Console.WriteLine("String Value is " + (item as string));
                }
                else if (item is bool)
                {
                    Console.WriteLine("Boolean Value is " + item.ToString());
                }
                else if (item is int)
                {
                    Console.WriteLine("Boolean Value is " + item.ToString());
                    sum = sum + (int) item;
                }
            }
            Console.WriteLine("Sum of integer values is " + sum.ToString());
        //         
        }
    }
}
