using System;
using System.Globalization;

namespace Exercicio1_Poo {
    class Program {
        static void Main(string[] args) {
            Retangulo A = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            A.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            A.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(A);
            
        }
    }
}
