using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Acciones
{
    public class ResolverTriangulo
    {
        public double Resolver(double lado1, double lado2, double lado3,string Operacion)
        {
            if (Operacion.Equals("P") || Operacion.Equals("A"))
            {
                Triangulo resolver = new Triangulo();
                if (Operacion.Equals("P"))
                {
                    return resolver.ResolverPerimetro(lado1, lado2,lado3);
                }
                else
                {
                    return resolver.ResolverArea(lado1, lado2, lado3);
                }
            }
           return 0;
        }
    }
}
