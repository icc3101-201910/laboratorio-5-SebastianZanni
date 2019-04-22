using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Ingrese el valor inicial: ");
            int valinicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de operaciones a realizar:");
            int operaciones = Convert.ToInt32(Console.ReadLine());

            Calculadora calculadora = new Calculadora(valinicial);
           calculadora.calculadoras.Add(new RobotFibonacci());
            calculadora.calculadoras.Add(new PersonaQueSuma5());
            calculadora.calculadoras.Add(new Cuadrado());
            calculadora.calculadoras.Add(new Cubo());
            calculadora.calculadoras.Add(new PerroFactorial());

            for (int i = 1; i <= operaciones; i++){
                Console.WriteLine("Esta es la operacion " + i + "\n");
                Console.WriteLine("[0]Robot Fibonacci \n");
                Console.WriteLine("[1]Persona que suma 5 \n");
                Console.WriteLine("[2]Cuadrado \n");
                Console.WriteLine("[3]Cubo \n");
                Console.WriteLine("[4]Perro Factorial \n");
                int operacion = Convert.ToInt32(Console.ReadLine());

                calculadora.Calcular(operacion);

            }

            Console.ReadKey();
        }
    }
}
