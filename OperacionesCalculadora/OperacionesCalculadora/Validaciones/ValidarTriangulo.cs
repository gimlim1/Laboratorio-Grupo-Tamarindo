using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Validaciones
{
    public class ValidarTriangulo
    {
        public bool Validar(double lado1, double lado2, double lado3)
        {

            bool validacion = false;

            if (((lado1 + lado2) > lado3) && ((lado1 + lado3) > lado2) && ((lado2 + lado3) > lado1))
            {
                validacion = true;
            }

            return validacion;

        }
    }
}
