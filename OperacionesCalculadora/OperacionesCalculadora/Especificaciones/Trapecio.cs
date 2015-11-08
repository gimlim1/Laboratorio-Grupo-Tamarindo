using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Trapecio
    {
        public double ResolverArea(double lado1, double lado2, double altura)
        {
            Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
            if (validar.Cuadraticoconaltura(lado1,lado2,altura))
            {
                return (lado1 + lado2)*altura / 2;
            }
            return 0;
        }

        public double ResolverPerimetro(double lado1,double lado2)
        {
            Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
            if (validar.Cuadraticocondos(lado1, lado2))
            {
                return lado1 + (lado1 / 2) + 2 * (lado2);
            }
            return 0;
        }
    }
}
