using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Modificar el ejercicio anterior para que aparezca un rombo. */

namespace Program6
{
    class Program6
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.WriteLine("Ingrese un número entero para poder crear un rombo de asteriscos: ");
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
            for (int i = 0; i < num; i++)
            {

                for (int j = 0; j <i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k =0 ; k <((num-i-1)*2)-1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
                Console.Read();
        }
    }
}
