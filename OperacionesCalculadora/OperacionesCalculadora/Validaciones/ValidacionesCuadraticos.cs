using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Validaciones
{
    public class ValidacionesCuadraticos
    {
       public Boolean Cuadratico (double lado1,double lado2,double altura)
        {
            if(lado1>0 && lado2>0 && altura>0)
            {
                return true;
            }
            return false;
        }
 }
}