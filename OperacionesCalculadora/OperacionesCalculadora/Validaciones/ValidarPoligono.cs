using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Validaciones
{
    public class ValidarPoligono
    {
        public bool Validacionlados(double lados)
        {
            bool Validacion = false;
            if (lados >= 5 && lados <= 16)
            {
                Validacion = true;
            }
            return Validacion;

        }
        public Boolean ValidarCero(double lados,double Lvalor)
        {
            if (lados>0 && Lvalor>0)
            {
                return true;
            }
            return false;
        }
    }
}
