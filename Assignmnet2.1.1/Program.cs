/*
1. Design a class hierarchy of your choice. (Need only class files)
*/

// Character creation
Console.WriteLine("Character creation");
Console.Write("Enter character name: ");
string characterName = Console.ReadLine();
Console.WriteLine($"Character name: {characterName}");

Console.WriteLine("Choose your class (warrior(1), rogue(2), mage(3), archer(4)): ");
string ClassSelection = Console.ReadLine();
switch (ClassSelection)
{
    case "1":
        Console.WriteLine("Warrior class selected");
        break;
    case "2":
       Console.WriteLine("Rogue class selected");
        break;
    case "3":
        Console.WriteLine("Mage class selected");
        break;
    case "4":
        Console.WriteLine("Archer class selected");
        break;
    default:
        Console.WriteLine("Invalid class selection");
        break;
}
//player
public class character
{
    public string Name { get; set; }
    public int level { get; set; }
    
}
//playable character class
public class playableClass : character
{
    public int attackPower { get; set; }
    public int defensePower { get; set; }
    public int health { get; set; }
    public int experience { get; set; }
}


//Different classes
public class warrior : playableClass
{
    public int rage { get; set; }
}
public class mage : playableClass
{
    public int mana { get; set; }
}
public class archer : playableClass
{
    public int agility { get; set; }
    public int stamina { get; set; }
    public int focus { get; set; }
    public int ammo { get; set; }
}
public class rogue : playableClass
{
    public int stamina { get; set; }
    public int stealth { get; set; }
}
