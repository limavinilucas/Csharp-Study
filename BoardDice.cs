// See https://aka.ms/new-console-template for more information
Console.WriteLine("\t-= Welcome to Dice's =-\t");
Console.WriteLine("> Please, press 'Enter' to continue... \t");
Console.ReadLine();
int dice = new Random().Next(200);
Console.WriteLine($"Dice's face: {dice}");