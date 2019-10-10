using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear un programa que muestre un menú como este:
1) Salir
2) Sumatorio
3) Factorial
Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba. Si se
elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial (en ambos casos el programa
pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). Tras calcular el sumatorio o la
factorial e indicar el resultado, el programa volverá a mostrar el menú y así sucesivamente.*/

namespace Program10
{
    class Program10
    {
        static void Main(string[] args)
        {
            int opcion, num, fact = 1,sum=0;
            do
            {
                Console.WriteLine("1) Salir");
                Console.WriteLine("2) Sumatorio");
                Console.WriteLine("3) Factorial");
                Console.Write("\n");
                Console.WriteLine("Ingrese la opción a elegir: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        break;
                    
                    case 2:
                        Console.WriteLine("Ingrese un número: ");
                        num = int.Parse(Console.ReadLine());
                        sum = num + num;
                        Console.WriteLine("La sumatoria del número ingresado es: "+sum);
                        break;
                    
                    case 3:
                        Console.WriteLine("Ingrese un número: ");
                        num = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= num; i++)
                        {
                            fact = fact * i;
                        }
                        Console.WriteLine("El factorial del número "+num+" es: "+fact);
                        break;
                }
                Console.Write("\n");
            } while (opcion!=1);
            
        }
    }
}
