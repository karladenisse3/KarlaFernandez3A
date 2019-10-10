using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de
asteriscos.Por ejemplo, si se introduce el 6, el resultado sería:
 *
 ***
 *****
 *******
 *********
 *********** 
*/

namespace Program5
{
    class Program5
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.WriteLine("Ingrese un número entero para poder crear una piramide de asteriscos: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num + 1; i++)
            {
                
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
