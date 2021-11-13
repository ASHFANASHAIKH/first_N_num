using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_N_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Display n terms of natural number and their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
              
            }
            
        }
    }
}
