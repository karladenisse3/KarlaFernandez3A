using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al
100, en la segunda los números del 100 al 1 */

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 101;
            for (int i = 1; i <= 100; i++)
            {
                    res = res-1;
                    Console.WriteLine(i+"   "+res);
            }
            Console.ReadKey();
        }
    }
}
