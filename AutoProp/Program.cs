

Console.WriteLine("****** Fun with Automatic Properties ******\n");
 var c = new Car();
c.PetName = "Frank";
c.Speed = 100;
c.Color = "Orange";
Console.WriteLine($"Your car is named {c.PetName}? That`s odd...");
c.DisplayStats();


Console.ReadLine();

class Car
{
    public string PetName { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    public void DisplayStats()
    {
        Console.WriteLine($"Car name: {PetName}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Color: {Color}");

    }

}