using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#");

        Console.Write("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine(color);

        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");

        string World = "Eritebwaa";
        Console.WriteLine($"My wife is {World}.");
    }

}