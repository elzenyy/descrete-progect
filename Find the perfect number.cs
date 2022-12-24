using System;

namespace Perfect_Number_Tester
{
    internal class Program
    {
        public static int findfactor(int input)
        {
            int sum = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    sum = sum + i;
                }

            }

            return sum;

        }

        static void Main(string[] args)
        {
          Console.WriteLine("Enter The Start Number");
            
             int n1 = int.Parse(Console.ReadLine());
              
                     Console.WriteLine("Enter The End Number");
          
                               int n2 = int.Parse(Console.ReadLine());
          
            for (int i = n1; i < n2; i++)
            {
                int result = findfactor(i);
                if (i == result)
                {
                    Console.WriteLine(i+" is a perfect number");
                }
            }

        }
    }
}