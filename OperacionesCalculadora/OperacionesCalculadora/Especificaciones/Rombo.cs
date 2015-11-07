using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora
{
    public class Rombo
    {
        public void ResolverArea(double diagonal,double diagonal2,double lado,ref double resultado){

            ref resultado = diagonal * diagonal2 / 2; 
        }


    }
}