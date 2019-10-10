using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. La primera
cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna cuenta de dos
en dos y la tercera de tres. */

namespace Program8
{
    class Program8
    {
        static void Main(string[] args)
        {
            int num,seg=0,ter=0;
            Console.WriteLine("Ingrese un número entero: ");
            num = int.Parse(Console.ReadLine());
            if (num>0) {
                for (int i = 1; i <= num; i++)
                {
                    seg = seg + 2;
                    ter = ter + 3;
                    Console.WriteLine(i + " " + seg+" "+ter);
                }
            }
            else
            {
                Console.WriteLine("Número invalido...vuelva a ingresar un número entero y positivo");
            }
            Console.ReadKey();
        }
    }
}
