using System;
using System.Globalization;

namespace Produto {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; } //Snipet Prop cria um Auto Properties

        public Produto() {
            
        }



        public Produto(string nome, double preco, int qtd) {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque() {
            return Preco * Qtd;
        }

        public void AdicionarProdutos(int quantity) {
            Qtd += quantity;
        }
        public void RemoverProdutos(int quantity) {
            Qtd -= quantity;
        }

        
        public override string ToString() => $"{_nome} \nR$ {Preco.ToString("F2",CultureInfo.InvariantCulture)}\n{Qtd} unidades\nTotal: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";

    }
    /*
     Atributos Privados
    Propriedades autoimplementadas
    Construtores
    Propriedades customizadas
    Outros métodos da classe
     
     */
}
