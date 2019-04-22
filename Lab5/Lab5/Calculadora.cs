using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Calculadora
    {
        private int numero;
        public List<ICalcular> calculadoras;
        Random random = new Random();

        public Calculadora(int valinicial)
        {
            this.numero = valinicial;
            calculadoras = new List<ICalcular>();
        }

        public int getNumero()
        {
            return numero;
        }

        public void Calcular(int eleccion)
        {
        
            ICalcular calc = calculadoras[eleccion];
         
            numero = calc.Calcular(numero);
            Console.WriteLine("\n"+"El numero tras la operacion realizada es: " +getNumero()+"\n");

        }

    }
}
