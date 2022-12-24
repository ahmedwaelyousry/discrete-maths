using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_maths_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, prime = 0;
            Console.WriteLine("Enter the first number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = int.Parse(Console.ReadLine());
            if (n1 == 1)
            {
                n1++;
            }
            if (n1 == 0)
            {
                n1 += 2;
            }
            for (int i = n1; i <= n2; i++)
            {
                for (int l = 2; l < i; l++)
                {
                    if (i % l == 0)
                    {
                        prime++;
                    }

                }
                if (prime == 0)
                {
                    Console.WriteLine(i + " is a prime number");
                }
                else
                {
                    prime = 0;
                }
            }
        }
    }
}