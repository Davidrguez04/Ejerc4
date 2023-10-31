/*Escriba un programa que solicite de forma repetida un número entero. Cada vez que se introduzca un 
 * número entero se calculará la multiplicación: 1*2*3*4*...*n-1*n; y se mostrará por consola el resultado.
 * Tras mostrar el resultado se preguntará si se quiere introducir un nuevo número. Si la respuesta es 's',
 * se continuará con la ejecución solicitando otra vez el número entero. En caso contrario, se cerrará la 
 * aplicación.
Se desarrollarán un mínimo de dos servicios: uno para la operativa de cálculo; y otro para solicitud del 
número y el control de las iteraciones.
 */

using Ejerc4.Servicios;

namespace Ejerc4.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazCalculo ni=new ImplCalculo();
            InterfazNumero mi=new ImplNumero();

            int num = mi.devuelveNumero();

            ni.calculoFac(num);
        }

       
    }
}
