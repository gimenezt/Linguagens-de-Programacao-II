using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2, soma;
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("A soma é: " + soma);
        }
    }
}
