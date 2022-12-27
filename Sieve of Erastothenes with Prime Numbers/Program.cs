using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find all prime numbers up to that number: ");
            int n = int.Parse(Console.ReadLine());
            // Create a boolean array "prime[0..n]" and
            // initialize all entries it as true. A value
            // in prime[i] will finally be false if i is
            // Not a prime, else true.
            bool[] prime = new bool[n + 1];
            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int j = 2; j * j <= n; j++)
            {
                if (prime[j] == true)
                {
                    for (int i = j * j; i <= n; i += j)
                        prime[i] = false;
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }
        }
    }
}
