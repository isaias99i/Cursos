using System;
using System.Globalization;

namespace ExercicioBancoPoo {
    class Program {
        static void Main(string[] args) {
            ContaBancaria contaA;
            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Digite o valor de depósito inicial: R$");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaA = new ContaBancaria(numConta, titular, depositoInicial);
            }
            else {
                 contaA = new ContaBancaria(numConta, titular);
            }
            Console.WriteLine($"\nDados da conta:\n {contaA}");
            Console.Write("\nDigite um valor para depósito: R$ ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaA.Deposito(valor);
            Console.WriteLine($"Dados da Conta Atualizados:\n {contaA}");
            Console.Write("\nDigite um valor para saque: R$ ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaA.Saque(valor);
            Console.WriteLine($"Dados da Conta Atualizados:\n {contaA}");
        }
    }
}
