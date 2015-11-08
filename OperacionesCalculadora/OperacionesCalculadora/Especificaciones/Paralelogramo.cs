﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Paralelogramo
    {

        public double ResolverArea(double lado1, double altura)
        {
            Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
            if (validar.Cuadraticocondos(lado1, altura))
            {
                return  lado1 * altura;
            }
            return 0;
        }

        public double ResolverPerimetro(double lado1, double lado2)
        {
            Validaciones.ValidacionesCuadraticos validar = new Validaciones.ValidacionesCuadraticos();
            if (validar.Cuadraticocondos(lado1, lado2))
            {
                return  (lado1 * 2)+(lado2 * 2);
            }
            return 0;
        }




    }
}
