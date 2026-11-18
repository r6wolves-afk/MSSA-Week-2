/*
 Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.
 */
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath =  "c:\\details.txt";

        // Write details to the file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Name: William Judge");
            writer.WriteLine("Age: 42");
            writer.WriteLine("Address: xxxx St, City, State");
        }

        // Read details from the file and print to console
        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
