using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalno_ponavljanje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi te n broj: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Fibonaccijev = new int[100];
            Fibonaccijev[0] = 0;
            Fibonaccijev[1] = 1;
            for (int i = 1; i <= n; i++)
            {
                Fibonaccijev[i + 1] = Fibonaccijev[i] + Fibonaccijev[i - 1];
            }
            Console.WriteLine("Fibonaccijev {0}. broj je: {1}", n, Fibonaccijev[n]);

            Console.ReadKey();
        }
    }
}
