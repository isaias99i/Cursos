using System;
using System.Globalization;
namespace estoque {
    class Program {
        static void Main(string[] args) {

            Produto P1 = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            P1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            P1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            P1.qtd = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {P1}");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            P1.AdicionarProdutos(quantity);
            Console.WriteLine(P1);
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantity = int.Parse(Console.ReadLine());
            P1.RemoverProdutos(quantity);
            Console.WriteLine(P1);




        }
    }
}
