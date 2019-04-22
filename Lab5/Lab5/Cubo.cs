using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Cubo : ICalcular
    {
        public int Calcular(int numero)
        {
            int cubo = numero * numero * numero;
            if (cubo > 2147483647) //Restriccion que no sea mayor que el int mas grande.
            {
                return 2147483647;
            }
            else
            {
                return cubo;
            }
        }
    }
}
