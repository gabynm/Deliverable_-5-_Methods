/* Name: Gabriela Mejias
 * Date: February 16, 2023
 * Description: Create a randomized array and return its summation
 */

using System;
namespace Assignment_5
{
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int input = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    Console.Write("Enter a number between 5 and 15: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input < 5 || input > 15)
                    {
                        Console.WriteLine("Error: Number not in range.");
                    }
                    else
                    {
                        valid = true;
                        int[] MyArray = random_array(input);
                        Console.Write("The elements in the random array are: ");
                        foreach (int i in MyArray)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("The sum is : " + sum(MyArray));
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: invalid number.");
                }

            }

        }
    }
}