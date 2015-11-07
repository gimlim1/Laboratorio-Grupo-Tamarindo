using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Rectangulo
    {


        public double ResolverArea(double lado1, double lado2)
        {
            return lado1 * lado2;
        }

        public double ResolverPerimetro(double lado1, double lado2)
        {
            return  (lado1 * 2)+ (lado2 *2);
        }



    }
}
