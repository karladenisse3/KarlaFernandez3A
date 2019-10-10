using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que lea una serie de números por teclado e indique cuál es el mayor.

namespace KarlaFernández3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, val=0,mayor=0;
            string linea;
            Console.WriteLine("Escriba la cantidad de valores a ingresar: "); linea = Console.ReadLine();
            num = int.Parse(linea);
            Console.Write("\n");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Ingrese valor: ");linea = Console.ReadLine();
                val = int.Parse(linea);
            if (val>mayor)
            {
                mayor = val;
            }
            }
            Console.Write("\n");
            Console.WriteLine("El número mayor es: " + mayor);
            Console.ReadLine();
        }
    }
}
