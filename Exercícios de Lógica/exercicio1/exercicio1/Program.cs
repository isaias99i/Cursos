using System;
using System.Globalization;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {
            /*Exercicio 1
             * int n1, n2;
            Console.WriteLine("Digite o primeiro numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($"Soma = {soma}");
            */

            /*Exercicio 2
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine($"A = {area:F4}",CultureInfo.InvariantCulture);
            */

            /*Exercicio 3
            int[] vlr =  new int[4];
            
            for(int i =0; i<4; i++) {
                Console.WriteLine($"Digite o {i+1}º número: ");
                vlr[i] = int.Parse(Console.ReadLine());
            }
            int diferenca = (vlr[0] * vlr[1]) - (vlr[2] * vlr[3]);
            Console.WriteLine($"DIFERENÇA = {diferenca}");
            */

            /*Exercicio 4
             * int numFunc;
            double salHora, horasTrab, salLiquido;
            Console.WriteLine("Digite o número do funcionário: ");
            numFunc = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Horas trabalhadas: ");
            horasTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor Hora: ");
            salHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            salLiquido = horasTrab * salHora;

            Console.WriteLine($"NUMBER = {numFunc}",CultureInfo.InvariantCulture);
            Console.WriteLine($"SALARY = U$ {salLiquido:F2}",CultureInfo.InvariantCulture);
            */




        }
    }
}
