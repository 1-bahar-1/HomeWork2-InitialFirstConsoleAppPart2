using System;

public class Statistics
{
    
    public void AnalyzeNumbers(int num1, ref int num2, out int num3)
    {
       
        num3 = num1 + num2;

        num2 = num2 * num2;

        Console.WriteLine($"{num1}" );
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter number1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter number2: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter number3: ");
        int c = int.Parse(Console.ReadLine());

      
        Console.WriteLine("---Befor The Change---");
        Console.WriteLine($" num1: {a}");
        Console.WriteLine($" num2: {b}");
        Console.WriteLine($" num3: {c}");

       
        Statistics stats = new Statistics();

        
        stats.AnalyzeNumbers(a, ref b, out c);

       
        Console.WriteLine("---After The Change---");
        Console.WriteLine($" num1: {a}");
        Console.WriteLine($" num2: {b}");
        Console.WriteLine($" num3: {c}");
    }
}