using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers then type 0 when it's finished");
        int number;
        List<int> numbers = new List<int>();
        do
        {
            Console.WriteLine("Enter a number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine("The sum of the numbers is " + sum);
        Console.WriteLine("The average of the numbers is " + numbers.Average());
        Console.WriteLine("The biggest number is " + numbers.Max());
        numbers.Sort();
        foreach (int n in numbers) {
            Console.WriteLine(n);
        }
    }
}