using System;
using System.Globalization;

namespace Exercicio1_Poo {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() => Largura * Altura;
        public double Perimetro() => 2 * (Largura + Altura);
        public double Diagonal() => Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));

        public override string ToString() => $"AREA: {Area().ToString("F2", CultureInfo.InvariantCulture)}\n PERÍMETRO = {Perimetro().ToString("F2",CultureInfo.InvariantCulture)}\n DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
