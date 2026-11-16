/*
Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. (May use a struct / class to represent the student)
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
*/

//User Prompting and input collection for student details
Console.WriteLine("Input the Student ID of the student :");
int studentId = int.Parse(Console.ReadLine());
Console.WriteLine($"Input the Name of the Student :");
string name = Console.ReadLine();
Console.WriteLine($"Input {name}'s grade in physics:");
int physicsMarks = int.Parse(Console.ReadLine());
Console.WriteLine($"Input {name}'s grade in chemistry:");
int chemistryMarks = int.Parse(Console.ReadLine());
Console.WriteLine($"Input {name}'s grade in computer application:");
int computerApplicationMarks = int.Parse(Console.ReadLine());

//results of input data
int totalMarks = physicsMarks + chemistryMarks + computerApplicationMarks;
double percentage = (double)totalMarks / 3;
string division;
if (percentage >= 60)
{
    division = "First";
}
else if (percentage >= 50)
{
    division = "Second";
}
else if (percentage >= 40)
{
    division = "Third";
}
else
{
    division = "Fail";
}

//Display the results
Console.WriteLine($"Roll No : {studentId}");
Console.WriteLine($"Name of Student : {name}");
Console.WriteLine($"Marks in Physics : {physicsMarks}");
Console.WriteLine($"Marks in Chemistry : {chemistryMarks}");
Console.WriteLine($"Marks in Computer Application : {computerApplicationMarks}");
Console.WriteLine($"Total Marks = {totalMarks}");
Console.WriteLine($"Percentage = {percentage}");
Console.WriteLine($"Division = {division}");

//student class stores the details and calculated results for a student
class Student
{
    public int StudentId;
    public string Name;
    public int PhysicsMarks;
    public int ChemistryMarks;
    public int ComputerApplicationMarks;
    public int TotalMarks;
    public double Percentage;
    public string Division;
}

