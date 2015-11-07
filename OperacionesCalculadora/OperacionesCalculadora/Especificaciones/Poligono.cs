using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Poligono
    {

        /*  6.	Creen un wcf que reciba:
  a.un valor que indique si desea calcular el perímetro o el área de un polígono regular de 5 o más lados.La cantidad máxima permitida de lados es 16.
  b.el número de lados de que consta la figura
  c.el tamaño de cada uno de ellos (como la figura es regular, todos los lados miden exactamente lo mismo, por lo que sólo se recibe un valor)
  Además, que devuelva el resultado de calcular ese perímetro o esa área. */


        Validaciones.ValidarPoligono validar = new Validaciones.ValidarPoligono();

        public double ResolverPerimetro(double lados, double Lvalor)
        {
            
            bool validacion = validar.Validacionlados(lados);
            if (validacion == true) {
                return lados * Lvalor;
            }
            return 0;
            
        }

        public double ResolverArea(double lados, double Lvalor)
        {

            bool validacion = validar.Validacionlados(lados);
            if (validacion == true)
            {
                double anguloC = (360 / lados);
                double apotema = Lvalor / (2 * Math.Tan(anguloC / 2));
                return (ResolverPerimetro(lados, Lvalor)*apotema)/2;
            }
            return 0;

        }





    }
}
