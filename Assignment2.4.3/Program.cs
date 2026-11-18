/*
Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

Test Data :

Input the value for X coordinate :7

Input the value for Y coordinate :9

Expected Output :

The coordinate point (7,9) lies in the First quadrant.
*/

using System;
class PointFinder
{
    static void Main()
    {
        Console.WriteLine("Enter the X coordinate:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Y coordinate:");
        int y = int.Parse(Console.ReadLine());


        // Determine the quadrant of the point
        if (x > 0 && y > 0)
            Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", x, y);
        else if (x < 0 && y > 0)
            Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant.", x, y);
        else if (x < 0 && y < 0)
            Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant.", x, y);
        else if (x > 0 && y < 0)
            Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quadrant.", x, y);
        else if (x == 0 && y != 0)
            Console.WriteLine("The coordinate point ({0},{1}) lies on the Y axis.", x, y);
        else if (x != 0 && y == 0)
            Console.WriteLine("The coordinate point ({0},{1}) lies on the X axis.", x, y);
        else
            Console.WriteLine("The coordinate point ({0},{1}) is at the origin.", x, y);
            
    }
}
