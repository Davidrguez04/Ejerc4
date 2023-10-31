using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc4.Servicios
{
    internal class ImplNumero:InterfazNumero
    {
        public int devuelveNumero()
        {
            
            char respuesta;
            int numero;
            InterfazCalculo ni = new ImplCalculo();
            do
            {
                Console.WriteLine("Introduzca un número entero: ");
                if (int.TryParse(Console.ReadLine(), out  numero))
                {

                    int fac = ni.calculoFac(numero);
                    Console.WriteLine($"El factorial de " + numero + " es: " + fac + "");

                    Console.Write("¿Desea introducir otro número? (s/n): ");
                    respuesta = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                    respuesta = 's'; // Para seguir en el bucle ya que no lo ha introducido bien el número
                }
            } while (respuesta == 's' || respuesta == 'S');

            return numero;

        }

        
        


    }
    
}
