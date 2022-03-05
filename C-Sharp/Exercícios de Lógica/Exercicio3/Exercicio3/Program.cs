using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            int tentativa = 0;
            Console.WriteLine("Digite um valor padrão para senha");
            int senha = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a senha");
                tentativa = int.Parse(Console.ReadLine());
            while (tentativa != senha) {
                Console.WriteLine("Senha incorreta");
                tentativa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta!!!");

        }
    }
}
