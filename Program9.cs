using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15.*/

namespace Program9
{
    class Program9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+i*j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
            
        }
    }
}
