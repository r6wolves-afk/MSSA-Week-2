/*
Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
*/
string userid = "JMoleski4";
string password = "password";

int attempts = 0;

while (attempts < 3)
{
    Console.Write("Enter userid: ");
    string inputUserid = Console.ReadLine();
    Console.Write("Enter password: ");
    string inputPassword = Console.ReadLine();

    if (inputUserid == userid && inputPassword == password)
    {
        Console.WriteLine("Access granted.");
        break;
    }
    else
    {
        attempts++;
        Console.WriteLine("Invalid userid or password. Attempt {0} of 3.", attempts);
    }
}

if (attempts == 3)
{
    Console.WriteLine("Access denied.");
}
