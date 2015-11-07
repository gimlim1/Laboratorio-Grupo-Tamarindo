using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Especificaciones
{
    public class Triangulo
    {

        public double ResolverArea(double lado1, double lado2, double lado3)
        {

            if (ValidarTriangulo( lado1,  lado2,  lado3) == true)
            {

                double semiperimetro = ResolverPerimetro(lado1, lado2, lado3);
                return Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
            }
            return 0;
        }

        public double ResolverPerimetro(double lado1, double lado2, double lado3)
        {

            if (ValidarTriangulo(lado1, lado2, lado3) == true)
            {
                return lado1 + lado2 + lado3;
            }
            return 0;
        }

        public bool ValidarTriangulo(double lado1, double lado2, double lado3) {

            bool validacion = false;

            if (((lado1 + lado2) > lado3) && ((lado1 + lado3) > lado2) && ((lado2 + lado3) > lado1))
            {
                validacion = true;
            }

            return validacion;

        }


    }
}
