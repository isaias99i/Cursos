using System;
using System.Globalization;

namespace QuartosExercicioVetor {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());
            Ocupantes[] Estudantes = new Ocupantes[n];
            
            for (int j = 0; j < n; j++) {
                Console.WriteLine($"Ocupante #{j + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Estudantes[quarto] = new Ocupantes (nome,  email);
            }
            //Organizar quartos
            


            Console.WriteLine("Quartos comprados: ");
            for (int l = 0; l < 10; l++){
                if (Estudantes[l] != null) {
                    Console.WriteLine($"{l}: {Estudantes[l]}");
                }
                
            }


        }
    }
}
