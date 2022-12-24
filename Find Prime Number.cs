using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Start Number:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The End Number:");

            int n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                bool number = true;
                if (i == 1)
                {
                    number = false;

                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            number = false;
                            break;
                        }
                    }
                    if (number)
                    {
                        Console.WriteLine("the prime number is:" + i);
                    }
                }




            }
        }
    }
}



