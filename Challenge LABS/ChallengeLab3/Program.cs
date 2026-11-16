/*
Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output:

666666

66666

6666

666

66

6
*/
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Enter the desired width: ");
int width = int.Parse(Console.ReadLine());

for (int i = width; i >= 1; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(number);
    }
    Console.WriteLine();
}
