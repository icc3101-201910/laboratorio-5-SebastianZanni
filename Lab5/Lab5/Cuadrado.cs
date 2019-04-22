using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Cuadrado:ICalcular
    {
        public int Calcular(int numero)
        {
            int cuadrado = numero * numero;
            if (cuadrado >= 2147483647) //Restriccion que no sea mayor que el int mas grande.
            {
                return 2147483647;
            }
            else
            {
                return cuadrado;
            }
        }
    }
}
