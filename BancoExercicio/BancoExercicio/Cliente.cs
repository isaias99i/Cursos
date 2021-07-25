using System.Globalization;
namespace BancoExercicio
{
    class Cliente
    {
        public int NumConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public void Deposit(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            if (valor > Saldo)
            {
                System.Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Saldo -= valor + 5;
            }
        }

        public Cliente()
        {
        }
        public Cliente(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
        }
        public Cliente(int numConta, string titular, double valor) : this(numConta, titular)
        {
            Deposit(valor);
        }
        public override string ToString() => $"Conta {NumConta}, Titular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
