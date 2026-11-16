/*
Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .

Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.

Inherit square class from shape and change the calculate area logic. Add property like side of square.

Take the input from user to select circle or square and display the calculated area . no hard coded values!
*/

Console.WriteLine("Select shape: 1 for Circle, 2 for Square");
int UserChoice = int.Parse(Console.ReadLine());

Shape shape;
if (UserChoice == 1)
{
    shape = new Circle();
    Console.WriteLine("What is the color of the circle?");
    string color = Console.ReadLine();
    shape.Color = color;
    shape.Name = "Circle";
    Console.WriteLine($"Enter the radius of the {shape.Color} {shape.Name}:");
    ((Circle)shape).Radius = double.Parse(Console.ReadLine());
}
else if (UserChoice == 2)
{
    shape = new Square();
    Console.WriteLine("What is the color of the square?");
    string color = Console.ReadLine();
    shape.Color = color;
    shape.Name = "Square";
    Console.WriteLine($"Enter the measurement for a side of the {shape.Color} {shape.Name}:");
    ((Square)shape).Side = double.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("Invalid choice");
    return;
}
Console.WriteLine($"The area of the {shape.Color} {shape.Name} is: {shape.CalculateArea()}");

//Class heirarchy for shapes
abstract class Shape
{
    //properties of the shape
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    //Method to calculate area of the shape
    public virtual double CalculateArea()
    {
        return 0;
    }
}

//Shape classes
class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}
class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}




