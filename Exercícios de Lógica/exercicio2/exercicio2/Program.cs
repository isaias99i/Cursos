using System;
using System.Globalization;

namespace exercicio2 {
    class Program {
        static void Main(string[] args) {

            /*Exercicio 1:
            int num = int.Parse(Console.ReadLine());
            string negativo = num >= 0 ? "NAO NEGATIVO" : "NEGATIVO";
            Console.WriteLine(negativo);
            */

            /*Exercicio 2:
            int num2 = int.Parse(Console.ReadLine());
            string parImpar = num2 % 2 == 0 ? "PAR" : "IMPAR";
            Console.WriteLine(parImpar);
            */

            /*Exercicio 3:
            int[] vlr = new int[2];
            for (int i = 0; i <2; i++) {
                Console.WriteLine($"Digite o {i+1}º valor: ");
                vlr[i] = int.Parse(Console.ReadLine());
            }
            string multiplos = (vlr[0] % vlr[1] == 0) || (vlr[1] % vlr[0] == 0) ? "São Multiplos" : "Não são Multiplos";
            Console.WriteLine(multiplos);
            */

            /*Exercicio 5:
            int[] codigo = { 1, 2, 3 };
            string[] especificacao = { "Cachorro Quente", "X-Salada", "X-Bacon" };
            double[] preco = { 4.00, 4.50, 5.00 };
            Console.WriteLine("Escolha um item: ");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++) {
                if (escolha == codigo[i]) {
                    Console.WriteLine($"Total: R$ {preco[i] * qtd:F2}");
                }
            }           
            */

            /*Exercicio 6:
            Console.WriteLine("Digite um valor");
            double num = double.Parse(Console.ReadLine());
            if (num >= 0 && num <= 25) {
                Console.WriteLine("Intervalo [0,25]",CultureInfo.InvariantCulture);
            }
            else if (num > 25 && num <= 50) {
                Console.WriteLine("Intervalo [25,50]", CultureInfo.InvariantCulture);
            }
            else if (num > 50 && num <= 75) {
                Console.WriteLine("Intervalo [50,75]", CultureInfo.InvariantCulture);
            }
            else if (num > 75 && num <= 100) {
                Console.WriteLine("Intervalo [75, 100]", CultureInfo.InvariantCulture);
            }else {
                Console.WriteLine("Fora de intervalo!");
            }
            */

        }





        

    }
}
