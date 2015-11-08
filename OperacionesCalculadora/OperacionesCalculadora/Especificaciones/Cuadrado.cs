using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Cuadrado
    {
        
        public double ResolverArea(double lado1)
        {
           Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
           if(validar.Cuadraticoconlado(lado1))
            {
                return lado1*lado1;
            }
            return 0;
        }

        public double ResolverPerimetro(double lado1)
        {
            Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
            if (validar.Cuadraticoconlado(lado1))
            {
                return lado1 * 4;
            }
            return 0;
        }



    }
}
