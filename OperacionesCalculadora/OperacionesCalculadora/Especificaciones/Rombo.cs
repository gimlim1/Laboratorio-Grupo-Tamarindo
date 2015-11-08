using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Rombo
    {

        public double ResolverArea(double lado1,double lado2){
            Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
            if (validar.Cuadraticocondos(lado1, lado2))
            {
                return lado1 * lado2 / 2;
            }
            return 0;
        }

        public double ResolverPerimetro(double altura)
        {
            Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
            if (validar.Cuadraticoconlado(altura))
            {
                return  4 * altura;
            }
            return 0;
        }
  }
}