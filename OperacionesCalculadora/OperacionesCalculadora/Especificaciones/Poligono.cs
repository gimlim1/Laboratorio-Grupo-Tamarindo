﻿using System;
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
            Validaciones.ValidarPoligono validar0 = new Validaciones.ValidarPoligono();
            if (validacion == true && validar0.ValidarCero(lados,Lvalor) == true) {
                return lados * Lvalor;
            }
            return 0;
            
        }

        public double ResolverArea(double lados, double Lvalor)
        {

            bool validacion = validar.Validacionlados(lados);
            Validaciones.ValidarPoligono validar0 = new Validaciones.ValidarPoligono();
            if (validacion == true && validar0.ValidarCero(lados, Lvalor) == true)
            {
                double anguloC = (360 / lados)/2;
                const double DTR = Math.PI / 180.0;
                double rad =Math.Tan(anguloC * DTR);
                double apotema = Lvalor / (2 * rad);
                return (ResolverPerimetro(lados, Lvalor)*apotema)/2;
            }
            return 0;

        }





    }
}
