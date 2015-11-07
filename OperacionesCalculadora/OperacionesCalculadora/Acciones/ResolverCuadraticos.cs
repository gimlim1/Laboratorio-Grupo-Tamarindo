using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCalculadora.Acciones
{
    public class ResolverCuadraticos
    {
        public double Resolver(double lado1, double lado2 , double altura,int figura,string Operacion)
        {
            switch(figura)
            {
                //paralelogramo
                case 1:
                    Paralelogramo resolver = new Paralelogramo();
                    if (Operacion.Equals("P"))
                    {
                        return resolver.ResolverPerimetro(lado1, lado2);
                    }  
                    else
                    {
                        return resolver.ResolverArea(lado1, altura);
                    }
            }

            return 0;
        }
    }
}
