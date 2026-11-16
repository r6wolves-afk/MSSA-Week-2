/*
Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static.
*/

//User Prompt
Console.WriteLine("Please choose an operation:");
Console.WriteLine("1. Add two numbers");
Console.WriteLine("2. Add three numbers");
Console.WriteLine("3. Multiply two numbers");
Console.WriteLine("4. Multiply three numbers");
Console.WriteLine("5. Exit");
int userinput = int.Parse(Console.ReadLine());

//Switch case to handle user input
switch (userinput)
{
   //Add two numbers
    case 1:
        Console.WriteLine("Enter the first number:");
        int addNum1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int addNum2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + Operations.Add(addNum1, addNum2));
        break;
   //Add three numbers
    case 2:
        Console.WriteLine("Enter the first number:");
        decimal addDec1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        decimal addDec2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        decimal addDec3 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + Operations.Add(addDec1, addDec2, addDec3));
        break;
   //Multiply two numbers
    case 3:
        Console.WriteLine("Enter the first number:");
        float mulNum1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        float mulNum2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + Operations.Multiply(mulNum1, mulNum2));
        break;
   //Multiply three numbers
    case 4:
        Console.WriteLine("Enter the first number:");
        float mulNum3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        float mulNum4 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        float mulNum5 = float.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + Operations.Multiply(mulNum3, mulNum4, mulNum5));
        break;
    case 5:
        Console.WriteLine("Exiting...");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}



//Operations class containing overloaded methods for Add and Multiply
public class Operations
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static decimal Add(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }

    public static float Multiply(float num1, float num2)
    {
        return num1 * num2;
    }

    public static float Multiply(float num1, float num2, float num3)
    {
        return num1 * num2 * num3;
    }
}

