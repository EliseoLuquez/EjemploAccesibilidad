using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace EjercicioParcial
{
    class Program
    {
        static void Main(string[] args)
        {

            // Numero miNumero = new Numero(); // error Numero() es privado
            Calculadora calculadora = new Calculadora();

            calculadora.numero = 3;

            Console.WriteLine(calculadora.numero);
            Console.ReadLine();
        }
    }
}
