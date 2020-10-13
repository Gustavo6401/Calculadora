using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me Informe O Primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Me Informe O Segundo Número");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Calculadora C = new Calculadora();
            int Soma = C.Somar(n1, n2);

            Console.WriteLine("A Soma é: " + Soma + "!");

            Console.ReadKey();
        }
    }
}
