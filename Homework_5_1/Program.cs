using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 7;
            int[] array = new int[n];
            Random random = new Random();
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 20);
                S += array[i];
                Console.Write("{0} ", array[i]);
            }
            {
                Console.WriteLine();
                Console.WriteLine("Сумма чисел в массиве: ");
                Console.Write(S);
                Console.WriteLine();
                Console.WriteLine("Среднее арифметичекое: ");
                Console.Write(S / n);
                Console.ReadKey();
            }
        }
    }
}


