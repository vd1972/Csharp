using System;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment: Basic 13
            // Solve all 13 problems below in as much of C# as possible.
            int totalValues = 5;
            PrintValues(totalValues);
            PrintOddValues(totalValues);
            SumValues(totalValues);

            int[] inputArray = new int[6];
            int[] inputArray1 = new int[3];
            int[] inputArray2 = new int[3];

            SetupArrays(inputArray, inputArray1, inputArray2);
            IterateAnArray(inputArray);
            IterateAnArray(inputArray1);
            IterateAnArray(inputArray2);

            SetupArrays(inputArray, inputArray1, inputArray2);
            FindMax(inputArray);
            FindMax(inputArray1);
            FindMax(inputArray2);

            SetupArrays(inputArray, inputArray1, inputArray2);
            SumOfArray(inputArray);
            SumOfArray(inputArray1);
            SumOfArray(inputArray2);

            CreateOddIntegerArray(totalValues);

            SetupArrays(inputArray, inputArray1, inputArray2);
            GreaterThanY(inputArray, 7);
            GreaterThanY(inputArray1, 0);
            GreaterThanY(inputArray2, 5);

            SetupArrays(inputArray, inputArray1, inputArray2);
            SquareTheValues(inputArray);
            SquareTheValues(inputArray1);
            SquareTheValues(inputArray2);

            SetupArrays(inputArray, inputArray1, inputArray2);
            EliminateNegativeNumbers(inputArray);
            EliminateNegativeNumbers(inputArray1);
            EliminateNegativeNumbers(inputArray2);

            SetupArrays(inputArray, inputArray1, inputArray2);
            MinMaxAvg(inputArray);
            MinMaxAvg(inputArray1);
            MinMaxAvg(inputArray2);

            SetupArrays(inputArray, inputArray1, inputArray2);
            ShiftArray(inputArray);
            ShiftArray(inputArray1);
            ShiftArray(inputArray2);

            SetupArrays(inputArray, inputArray1, inputArray2);
            NegativeToString(inputArray);
            NegativeToString(inputArray1);
            NegativeToString(inputArray2);
        }

        private static void SetupArrays(int[] inputArray, int[] inputArray1, int[] inputArray2)
        {
            int[] arr1 = {1,3,5,7,9,13};
            int[] arr2 = {-3, -5, -7};
            int[] arr3 = {2, 10, 3};
            for (int i = 0; i < arr1.Length; i++)
            {
                inputArray[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                inputArray1[i] = arr2[i];
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                inputArray2[i] = arr3[i];
            }
            // PrintArray("Initialized array 0 " , inputArray);
            // PrintArray("Initialized array 1 " , inputArray1);
            // PrintArray("Initialized array 2 " , inputArray2);
        }

        private static void PrintValues(int total)
        {
            Console.WriteLine("Task: Printing all numbers from 1 thru " + (total).ToString());
            // Print 1-255
            // Write a program (sets of instructions) that would print all the numbers from 1 to 255.
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void PrintOddValues(int total)
        {
            Console.WriteLine("Task: Printing odd values from 1 thru " + (total).ToString());
            // Print odd numbers between 1-255
            // Write a program (sets of instructions) that would print all the odd numbers from 1 to 255.
            for (int i = 1; i <= total; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void SumValues(int total)
        {
            Console.WriteLine("Task: Printing odd values from 1 thru " + (total).ToString());
            // Print Sum

            // Write a program that would print the numbers from 0 to 255 but this time, 
            // it would also print the sum of the numbers that have been printed so far. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            // New number: 3 Sum: 6
            // New Number: 255 Sum: ___.

            // Do NOT use an array to do this exercise.
            int runningSum = 0;
            for (int i = 1; i <= total; i++)
            {
                runningSum += i;
                Console.WriteLine("New Number: " + i.ToString() + " Sum: " + runningSum.ToString());
            }
        }

        private static void IterateAnArray(int[] x)
        {
            // Iterating through an Array

            // Given an array X, say [1,3,5,7,9,13], write a program that would iterate through each member of the array and print each value on the screen. Being able to loop through each member of the array is extremely important.
            foreach (var item in x)
            {
                Console.WriteLine(item);             
            }

        }

        private static void FindMax(int[] x)
        {
            // Find Max
            // Write a program (sets of instructions) that takes any array and prints the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            PrintArray("Source Array ", x);
            int maxValue = int.MinValue;
            foreach (int item in x)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }
            Console.WriteLine("Max value of the array is " + maxValue.ToString());             
        }

        private static void SumOfArray(int[] x)
        {
            // Get Average

            // Write a program that takes an array, and prints the AVERAGE of the values in the array. 
            // For example for an array [2, 10, 3], your program should print an average of 5. 
            // Again, make sure you come up with a simple base case and write instructions to solve
            //  that base case first, then test your instructions for other complicated cases. 
            // You can use a count function with this assignment.
            PrintArray("Source Array ", x);
            int sum = 0;
            foreach (int item in x)
            {
                sum += item;
            }
            Console.WriteLine("Sum value of the array is " + sum.ToString());        
        }

        private static void CreateOddIntegerArray(int TotalValues)
        {
            // Array with Odd Numbers

            // Write a program that creates an array 'y' that contains all the odd numbers between 1 to 255. 
            // When the program is done, 'y' should have the value of [1, 3, 5, 7, ... 255].
            int TotalOddValues = TotalValues/2 + 1;
            int[] oddValues = new int[TotalOddValues];
            int j = 0;
            for (int i = 1; i <= TotalValues; i++)
            {
                if (i%2 != 0)
                {
                    oddValues[j] = i;
                    ++j;
                }
            }

            // foreach (int item in oddValues)
            // {
            //     Console.WriteLine(item);                
            // }
            PrintArray("Final Array ", oddValues);
            
        }

        private static void GreaterThanY(int[] x, int y)
        {
            // Greater than Y

            // Write a program that takes an array and returns the number of values
            // in that array whose value is greater than a given value y.
            // For example, if array = [1, 3, 5, 7] and y = 3. 
            // After your program is run it will print 2 (since there are two values in the array that are greater than 3).
            PrintArray("Source Array ", x);
            int totalMatch = 0;
            foreach (int item in x)
            {
                if (item > y)
                    ++totalMatch;
            }
            Console.WriteLine("Total items greater than " + y.ToString() + " are " + totalMatch.ToString());
        }

        private static void SquareTheValues(int[] x)
        {
            // Square the Values
            // Given any array x, say [1, 5, 10, -2], create an algorithm (sets of instructions) 
            // that multiplies each value in the array by itself. When the program is done,
            //  the array x should have values that have been squared, say [1, 25, 100, 4].
            PrintArray("Source Array ", x);
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i]*x[i];
            }
            foreach (int item in y)
            {
                Console.WriteLine("Squared Value " + item.ToString());
            }
        }

        private static void EliminateNegativeNumbers(int[] x)
        {
            // Eliminate Negative Numbers

            // Given any array x, say [1, 5, 10, -2], create an algorithm that replaces any negative 
            // number with the value of 0. When the program is done, x should have no negative values, say [1, 5, 10, 0].
            PrintArray("Source Array ", x);
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)   
                   x[i] = 0;
            }

            // foreach (int item in x)
            // {
            //     Console.WriteLine(item);  
            // }
            PrintArray("Final Array ", x);
        }

        private static void MinMaxAvg(int[] x)
        {
            // Min, Max, and Average

            // Given any array x, say [1, 5, 10, -2], create an algorithm that prints
            // the maximum number in the array, 
            // the minimum value in the array,
            // and the average of the values in the array.
            // Eliminate Negative Numbers

            // Given any array x, say [1, 5, 10, -2], create an algorithm that replaces any negative 
            // number with the value of 0. When the program is done, x should have no negative values, say [1, 5, 10, 0].
            PrintArray("Source Array ", x);
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < min)   
                   min = x[i];

                if (x[i] > max)   
                   max = x[i];

                sum += x[i];
            }

            Console.WriteLine("Min value " + min.ToString());
            Console.WriteLine("Max value " + max.ToString());
            if (x.Length > 0)
               Console.WriteLine("Avg value " + (sum/x.Length).ToString());
            else
               Console.WriteLine("List is empty to find the Avg value ");

        }

        private static void ShiftArray(int[] x)
        {
            // Shifting the values in an array

            // Given any array x, say [1, 5, 10, 7, -2], create an algorithm that shifts
            // each number by one to the front and adds '0' to the end. 
            // For example, when the program is done,  if the array [1, 5, 10, 7, -2] is passed to
            // the function, it should become [5, 10, 7, -2, 0].
            PrintArray("Source Array ", x);
            for (int i = 0; i < x.Length/2; i++)
            {
                int temp = x[i];
                x[i] = x[x.Length - i - 1];
                x[x.Length - i - 1] = temp;
            }

            PrintArray("Final Array ", x);
        }

        private static void NegativeToString(int[] x)
        {
            // Number to String

            // Write a program that takes an array of numbers 
            // and replaces any negative number with the string 'Dojo'. 
            // For example, if array x is initially [-1, -3, 2] your function 
            // should return an array with values ['Dojo', 'Dojo', 2].
            PrintArray("Source array ", x);
            string[] y = new string[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    y[i] = "Dojo";
                }
                else
                {
                    y[i] = x[i].ToString();
                }
            }

            string strValue = "";
            for (int i = 0; i < y.Length; i++)
            {
                strValue += " " + y[i].ToString();
            }
            Console.WriteLine("Final array " + " [ " + strValue + " ]");
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

    }
}
