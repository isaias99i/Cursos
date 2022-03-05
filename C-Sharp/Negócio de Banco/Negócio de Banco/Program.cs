using Negócio_de_Banco.Entities;

namespace Negócio_de_Banco {
    class Program {
        static void Main(string[] args) {
            Account acc1 = new Account(101, "Carlos", 500.0);
            Account acc2 = new SavingsAccount(102, "Ana", 500,0.01);

            acc1.Withdraw(20.0);
            acc2.Withdraw(20.0);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc1.Balance);
        }
    }
}