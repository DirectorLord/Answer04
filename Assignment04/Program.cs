namespace Assignment04
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    public class Program
    {
        #region Function1
        public static void ValyeByType(int x, int y)
        {
            (x, y) = (y, x);
        } // function that swaps by value
        #endregion

        #region Function2
        public static void ValueByReference(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }// function that swaps by reference
        #endregion

        #region Function3
        // Function that accepts 4 parameters and returns the sum and difference of two numbers
        public static void SumSub(int n1, int n2, out int sum, out int sub)
        {
            sum = n1 + n2;
            sub = n1 - n2;
        }
        #endregion

        #region Function4
        // Function to calculate the sum of individual digits of a number
        public static void Sumamation(int x, int y, out int sum)
        {
            sum = x + y;
        }
        #endregion

        #region Function5
        public static void IsPrime(int number)
            //first
        {   //if condition to check if the number is less than or equal to 1
            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number.");
                //if less than one then it returns nothing
                return;
            }
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            //for loop to check if the number is divisible by any number from 2 to the square root of the number
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} is not a prime number.");
                    //if the number is divisible then it returns that it is not a prime number
                    return;
                }
            }
            Console.WriteLine($"{number} is a prime number.");

        }
        #endregion

        #region Function6
        //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        public static void MinMaxArray(int[] arr, out int min, out int max)
        {
            if (arr is null || arr.Length == 0)
            {
                Console.WriteLine("Array cant be null or empty. PLease enter a value");
            }
            min = arr[0];
            max = arr[0];
            //foreach loop since we are dealing with a collection of data / array
            
            foreach (int num in arr)
            {//if condition to check if the number is less than the minimum or greater than the maximum
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
        }
        #endregion

        #region Function7
        //Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter
        public static int Factorial(int number, out int result)
        {
            if (number < 0)
            {
                Console.WriteLine("The number must be more than 0");
            }
            int res = 1;
            for (int i = 2; i <= number; i++)
            {
                res *= i;
            }
        }
        ????
        #endregion

        #region Function8
        //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        public static void ChangeChar(string str, int position, char newChar)
        {
            if (position < 0 || position >= str.Length)
            {
                Console.WriteLine("Position is out of bounds.");
                return;
            }
            char[] charArray = str.ToCharArray();
            charArray[position] = newChar;
            string modifiedString = new string(charArray);
            Console.WriteLine($"Modified string: {modifiedString}");

        }
        #endregion
        public static void Main(string[] args)
        {
            #region Question1
            ////Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            ////Passing by value means that a copy of the variable is passed to the method, so changes made to the parameter inside the method do not affect the original variable.
            int num1 = 10, num2 = 5;
            Console.WriteLine("Passing by Value Example:");
            Console.WriteLine($" Number 1 = {num1}");
            Console.WriteLine($" Number 2 = {num2}");
            ValyeByType(num1, num2); // passing by value
            Console.WriteLine($" Number 1 = {num1}");
            Console.WriteLine($" Number 2 = {num2}");
            Console.WriteLine("-------------------------------");
            #endregion

            #region Question2
            //	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //Passing by reference means that a reference to the original variable is passed, so changes made to the parameter inside the method do affect the original variable.
            Console.WriteLine("Passing by reference Example:");
            Console.WriteLine($" Number 1 = {num1}");
            Console.WriteLine($" Number 2 = {num2}");
            ValueByReference(ref num1, ref num2); // passing by reference
            Console.WriteLine($" Number 1 = {num1}");
            Console.WriteLine($" Number 2 = {num2}");
            #endregion

            #region Question3
            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            Console.WriteLine("Enter the 2 nuymbers to sub and sum");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum, sub;
            SumSub(n1, n2, out sum, out sub);
            Console.WriteLine("The summation is: " + sum);
            Console.WriteLine("The subtraction is: " + sub);
            #endregion

            #region Question4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number

            Console.WriteLine("Enter a number to calculate the sum of its digits:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int sum2;
            Sumamation(x, y, out sum2);
            Console.WriteLine("The summation is: " + sum2);
            #endregion

            #region Question5
            //Write a program in C# Sharp to create a function to check whether a number is prime or not.
            Console.WriteLine("Enter a number to check if it is prime:");
            int number = Convert.ToInt32(Console.ReadLine());
            IsPrime(number);
            #endregion

            #region Question6
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            //making the user to input the size of the array
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min, max;
            MinMaxArray(arr, out min, out max);
            Console.WriteLine("The size of the array: "+ size);
            Console.WriteLine("The minimum: "+ min);
            Console.WriteLine("The maaximum: "+ max);
            #endregion

            #region Question7
            Create an iterative(non - recursive) function to calculate the factorial of the number specified as parameter
            Console.WriteLine("Enter a number to calculate its factorial: ");
            int factorial = Convert.ToInt32(Console.ReadLine());
            if (factorial < 0)
            {
                Console.WriteLine("The number must be more than 0");
            }
            else
            {
                int result = Factorial(factorial, res);
                Console.WriteLine($"The factorial of {factorial} is: {result}");
            }
            ?????
            #endregion

            #region Question8
            //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            Console.WriteLine("Enter a string to modify:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the position of the character to change (0 based):");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new character:");
            // how do i change the char bruh
            //nvm
            char newChar = Convert.ToChar(Console.ReadLine()); // Read a single character input
            Console.WriteLine(); // To move to the next line after reading the character
            ChangeChar(str, position, newChar);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("The string is: " + str);
            Console.WriteLine("The new char is: " + newChar);
            #endregion
        }
    }
}