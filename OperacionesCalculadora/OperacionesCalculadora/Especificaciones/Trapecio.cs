using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Trapecio
    {
        public double ResolverArea(double lado1, double lado2,double area)
        {
            return lado1 * lado2 / 2;
        }

        public double ResolverPerimetro(double altura)
        {
            return 4 * altura;

        }
    }
}
