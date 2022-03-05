using System;
using System.Globalization;

namespace estoque {
    class Produto {

        public string Nome;
        public double Preco;
        public int qtd;

        public void AdicionarProdutos(int quantity) {
            qtd += quantity;
        }
        public void RemoverProdutos(int quantity) {
            qtd -= quantity;
        }
        public double ValorTotalEmEstoque() {
            return (Preco * qtd);
        }

        //Console.WriteLine($"Dados Atualizados: {P1.Nome}, {P1.qtd} unidades, Total: R$ {P1.ValorTotalEmEstoque():F2}");
        public override string ToString() => $"Dados atualizados: {Nome}, {qtd} unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";

    }
}
