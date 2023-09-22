using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your marks: ");
        string marks = Console.ReadLine();
        int score = int.Parse(marks);
        string letter = "";
        string sign = "";
        int lastdigit = score % 10;

        // Console.WriteLine($"Last digit is:  {lastdigit}");

        if (score >= 90)
        {
            letter = "A";
        } 

        else if (score >= 80 && score < 90 && lastdigit >= 7)
        {
            letter = "B";
            sign = "+";
        }
        
        else if (score >= 80 && score < 90 && lastdigit < 3)
        {
            letter = "B";
            sign = "-";
        }

        else if (score >= 70 && score < 80 && lastdigit >= 7)
        {
            letter = "C";
            sign = "+";
        }
        
        else if (score >= 70 && score < 80 && lastdigit < 3)
        {
            letter = "C";
            sign = "-";
        }

        else if (score >= 60 && score < 70 && lastdigit >= 7)
        {
            letter = "D";
            sign = "+";
        }
        
        else if (score >= 60 && score < 70 && lastdigit < 3)
        {
            letter = "D";
            sign = "-";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}{sign}");
        
        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}