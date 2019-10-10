using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese
tamaño.Los asteriscos sólo se verán en el borde del cuadrado, no en el interior.*/

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.WriteLine("Ingrese un número entero para poder crear un cuadrado de asteriscos: "); 
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == 0 || i == num-1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        if (j == 0 || j == num-1)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
