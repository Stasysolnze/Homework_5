using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 5;

            int[,] t = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = 1 - (i + j) % 2;
                    {
                        Console.Write("{0,4} ", t[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
