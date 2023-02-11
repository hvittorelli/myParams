using System;

namespace myParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("How many random numbers should we generate?");
            int size = int.Parse(Console.ReadLine());
            int[] numbers= new int[size];
            Console.WriteLine("Here are the random numbers that were generated for you: ");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = r.Next(1,10);
            }
            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"The total sum of the numbers array = {Add(numbers)}");
            Console.WriteLine($"The total product of the numbers array = {Multiply(numbers)}");
        }
        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        static int Multiply(params int[] numbers)
        {
            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }

    }
}