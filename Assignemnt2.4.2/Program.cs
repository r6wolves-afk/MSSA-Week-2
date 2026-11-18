/*
. Write a C# Sharp program to find the largest of three numbers.

Test Data :

Input the 1st number :25

Input the 2nd number :63

Input the 3rd number :10

Expected Output :

The 2nd Number is the greatest among three
*/
using System;
class LargestNumber
{
    static void Main()
    {
        Console.WriteLine("Input the 1st number :");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the 2nd number :");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the 3rd number :");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
            Console.WriteLine("The 1st Number is the greatest among three");
        else if (num2 > num1 && num2 > num3)
            Console.WriteLine("The 2nd Number is the greatest among three");
        else
            Console.WriteLine("The 3rd Number is the greatest among three");
    }
}

