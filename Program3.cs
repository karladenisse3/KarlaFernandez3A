using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear un programa que lea cantidades y precios y al final indique el total de la factura.
Primero se pregunta:
Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo.
Después se pregunta:
Introduzca el precio que será un número decimal positivo.
La lectura termina cuando en la cantidad se introduzca un cero.Si es así se escribirá el total.*/

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;
            double pre,total=0,suma=0;
            string linea;
            do
            {
                Console.WriteLine("Introduzca la cantidad vendida");
                cant = int.Parse(Console.ReadLine());
                if (cant>0)
                {
                    Console.WriteLine("Introduzca el precio del producto");
                    pre = double.Parse(Console.ReadLine());
                    if (pre>0)
                    {
                        total = cant * pre;
                        Math.Truncate(suma = suma + total);
                    }
                    else
                    {
                        Console.WriteLine("Precio no valido vuelva a introducir un precio valido");
                    }
                }
                else
                {
                    Console.WriteLine("Cantidad no valida vuelva a introducir una valida");
                }
            } while (cant!=0);
            Console.WriteLine("El total vendido es "+suma);
            Console.ReadKey();
        }
    }
}
