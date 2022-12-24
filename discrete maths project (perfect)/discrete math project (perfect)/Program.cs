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
            int n1, n2, sum = 0;
            Console.WriteLine("Enter the first number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = int.Parse(Console.ReadLine());
            for(int i = n1; i<=n2; i++)
            {
                for(int l = 1; l<=i/2; l++)
                {
                    if(i % l == 0)
                    {
                        sum += l;
                    }
                }
                if(sum == i)
                {
                    Console.WriteLine(i + "is a perfect number");
                }
                sum = 0;
            }
        }
    }
}
