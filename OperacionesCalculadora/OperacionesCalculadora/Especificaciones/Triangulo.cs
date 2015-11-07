using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Especificaciones
{
    class Triangulo
    {

        public double ResolverArea(double lado1, double lado2, double lado3)
        {
            double semiperimetro = ResolverPerimetro(lado1, lado2, lado3);
            return Math.Sqrt(semiperimetro * (semiperimetro-lado1) * (semiperimetro-lado2) * (semiperimetro-lado3));
        }

        public double ResolverPerimetro(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public bool validarTriangulo(double lado1, double lado2, double lado3)
        {

            return true;
        }



    }
}
