using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Triangulo
    {

        Validaciones.ValidarTriangulo Validar = new Validaciones.ValidarTriangulo();

        public double ResolverArea(double lado1, double lado2, double lado3)
        {

            if (Validar.Validar( lado1,  lado2,  lado3) == true)
            {

                double semiperimetro = ResolverPerimetro(lado1, lado2, lado3)/2;
                return Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
            }
            return 0;
        }

        public double ResolverPerimetro(double lado1, double lado2, double lado3)
        {
            if (Validar.Validar(lado1, lado2, lado3) == true)
            {
                return lado1 + lado2 + lado3;
            }
            return 0;
        }

    }
}
