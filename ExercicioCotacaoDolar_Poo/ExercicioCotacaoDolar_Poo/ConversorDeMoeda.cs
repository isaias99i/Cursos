using System;
using System.Globalization;    
namespace ExercicioCotacaoDolar_Poo {
    class ConversorDeMoeda {

        public static double Iof = 1.06;
        public static double CotDolar(double CotAtual, double DolComprar) {
            return CotAtual * DolComprar * Iof;
        }



    }
}
