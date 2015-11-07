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
            switch (figura)
            {
                //paralelogramo
                case 1:
                
                    if (Operacion.Equals("P") || Operacion.Equals("A")){
                        Paralelogramo resolver = new Paralelogramo();
                        if (Operacion.Equals("P")){
                        return resolver.ResolverPerimetro(lado1, lado2);
                     }  
                     else
                     {
                        return resolver.ResolverArea(lado1, altura);
                     }
                   }
                    break;
                //Cuadrado
                case 2:
                    if (Operacion.Equals("P") || Operacion.Equals("A"))
                    {
                        Cuadrado resolver = new Cuadrado();
                        if (Operacion.Equals("P"))
                        {
                            return resolver.ResolverPerimetro(lado1);
                        }
                        else
                        {
                            return resolver.ResolverArea(lado1);
                        }
                    }
                    break;
               //Rectangulo
                case 3:
                    if (Operacion.Equals("P") || Operacion.Equals("A"))
                    {
                        Rectangulo resolver = new Rectangulo();
                        if (Operacion.Equals("P"))
                        {
                            return resolver.ResolverPerimetro(lado1, lado2);
                        }
                        else
                        {
                            return resolver.ResolverArea(lado1,lado2);
                        }
                    }
                    break;
              //Rombo
                case 4:
                    if (Operacion.Equals("P") || Operacion.Equals("A"))
                    {
                        Rombo resolver = new Rombo();
                        if (Operacion.Equals("P"))
                        {
                            return resolver.ResolverPerimetro(altura);
                        }
                        else
                        {
                            return resolver.ResolverArea(lado1, lado2);
                        }
                    }
                    break;
               //Romboide 
                case 5:
                    if (Operacion.Equals("P") || Operacion.Equals("A"))
                    {
                        Romboide resolver = new Romboide();
                        if (Operacion.Equals("P"))
                        {
                            return resolver.ResolverPerimetro(lado1, altura);
                        }
                        else
                        {
                            return resolver.ResolverArea(lado1, lado2);
                        }
                    }
                    break;

                case 6:
                    if (Operacion.Equals("P") || Operacion.Equals("A"))
                    {
                        Trapecio resolver = new Trapecio();
                        if (Operacion.Equals("P"))
                        {
                            return resolver.ResolverPerimetro(lado1, lado2);
                        }
                        else
                        {
                            return resolver.ResolverArea(lado1, lado2, altura);
                        }
                    }
                    break;

            }

            return 0;
        }
    }
}
