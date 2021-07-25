using System;
using System.Globalization;

namespace Exercicio3_Poo {
    class Aluno {
        public string Nome;
        public double Nota1 = 0, Nota2 = 0, Nota3 = 0;
        public double Media = 60;
        public double NotaFinal() => Nota1 + Nota2 + Nota3;
        public string Status() => NotaFinal() >= Media ? "Aprovado" : "Reprovado";

        public double Esforco() => Media - NotaFinal();
        

    }
}
