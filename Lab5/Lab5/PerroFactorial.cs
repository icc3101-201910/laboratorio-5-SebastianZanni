using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class PerroFactorial:ICalcular
    {
        public int Calcular(int numero)
        {
          if (numero > 12)
            {
                numero = 12;
            }
            
            int factorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                factorial = factorial * i;

            }
            return factorial;
            
            }
        }
    }

