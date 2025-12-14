using System;

class ArrayAnalyzer
{
    
    public void AnalyzeArray(int[] arr, ref int max, out double average)
    {
        if (arr.Length == 0)
        {
            max = 0;
            average = 0.0;
            return;
        }

        
        max = arr[0];
        double sum = 0;

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
                
            sum += num;
        }

        
        average = sum / arr.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Insert the array elements:");

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        ArrayAnalyzer analyzer = new ArrayAnalyzer();
        int max = 0;          
        double average;      

        analyzer.AnalyzeArray(numbers, ref max, out average);

        Console.WriteLine($"Max : {max}");
        Console.WriteLine($"Average: {average}");
    }
}