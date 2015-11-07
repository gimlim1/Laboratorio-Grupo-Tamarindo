using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Romboide
    {

        public double ResolverArea(double lado1, double lado2)
        {
            // base * ancho
            return lado1 * lado2;
        }

        public double ResolverPerimetro(double lado1,double altura)
        {

            // 2 * (b + h)
            return 2 * (lado1 + altura);

        }
    }
}
