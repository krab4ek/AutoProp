using AutoProp;

Console.WriteLine("****** Fun with Automatic Properties ******\n");
Car? c = new();
c.PetName = "Frank";
c.Speed = 100;
c.Color = "Orange";
Console.WriteLine($"Your car is named {c.PetName}? That`s odd...");
c.DisplayStats();


Console.ReadLine();

