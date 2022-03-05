using System;
using System.Globalization;

namespace ExercicioCotacaoDolar_Poo {
    class Program {
        
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dólar? ");
            double CotAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double DolComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = ConversorDeMoeda.CotDolar(CotAtual, DolComprar);
            Console.WriteLine($"Valor a ser pago em reais = R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
