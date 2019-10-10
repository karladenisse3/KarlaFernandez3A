using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares
por hora si éstas no superan las 35 horas.Cada hora por encima de 35 se considerará extra y se paga a
22 dólares.
El programa pide las horas del trabajador y devuelve el salario que se le debe pagar.
Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite.*/

namespace Program4
{
    class Program4
    {
        static void Main(string[] args)
        {
            int horas=15,salario=0,horasExtra;
            string otroSalario = "si";
            do
            {
                Console.Write("\n");
                Console.WriteLine("Ingrese horas a trabajar: ");
                int cantHoras = int.Parse(Console.ReadLine());
                if (horas > 35)
                {
                    salario = horas * 35;
                    horas = 22;
                    cantHoras = cantHoras - 35;
                    horasExtra = horas * cantHoras;
                    salario = salario + horasExtra;
                }
                else
                {
                    salario = horas * cantHoras;
                }
                Console.WriteLine("Su salario semanal es: "+salario);
                Console.Write("\n");
                Console.WriteLine("¿Desea calcular otro salario?    si o no");
                otroSalario = Console.ReadLine();
            } while (otroSalario=="si");
           
            
        }
    }
}
