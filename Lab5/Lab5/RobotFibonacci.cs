using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class RobotFibonacci:ICalcular
    {   public int Calcular(int numero)
        {
            if (numero > 46)
            {
                numero = 46;
            }

            int f0 = 0;
            int f1 = 1;

            List<int> fibonacci = new List<int>();
            fibonacci.Add(f0);
            fibonacci.Add(f1);
            if (numero == 0)
            {
                return fibonacci[0];
            }

            else if (numero == 1)
            {
                return fibonacci[1];
            }
            else
            {
                for (int i = 2; i <= numero; i++)

                {
                    fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                }
                return fibonacci[numero];
            }
        }
    }
}
