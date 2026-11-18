/*
. Write a program in C# Sharp to find the sum of all array elements.

Test Data :

Input the number of elements to be stored in the array :3

Input 3 elements in the array :

element - 0 : 2

element - 1 : 5

element - 2 : 8

Expected Output :

Sum of all elements stored in the array is : 15
MAKE YOUR OWN METHOD TO CALCULATE THE SUM OF ARRAY ELEMENTS
*/

using System;
class ArraysSum
{
    //Method to calculate the sum of array elements
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array :");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Input {0} elements in the array :", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum of all elements stored in the array is : {0}", SumArray(arr));
    }

    static int SumArray(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}
