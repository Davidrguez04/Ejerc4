using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc4.Servicios
{
    internal class ImplCalculo:InterfazCalculo
    {
        public int calculoFac(int num)
        {
            int fac = 1;
            for (int i = 1; i <= num; i++)
            {
                fac *= i;
            }
            return fac;
        }
    }
}
