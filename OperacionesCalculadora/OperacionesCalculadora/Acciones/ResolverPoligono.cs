using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Acciones
{
    public class ResolverPoligono
    {
        public double Resolver(double lados, double Lvalor,string Operacion)
        {
            if (Operacion.Equals("P") || Operacion.Equals("A"))
            {
                Poligono resolver = new Poligono();
                if (Operacion.Equals("P"))
                {
                    return resolver.ResolverPerimetro(lados, Lvalor);
                }
                else
                {
                    return resolver.ResolverArea(lados,Lvalor);
                }
            }
            return 0;
        }
    }
}
