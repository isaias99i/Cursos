using System.Globalization;
using System;

namespace BancoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the account:");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Enter the owner of account:");
            string titular = Console.ReadLine();
            Cliente C1 = new(numConta, titular);
            Console.Write("Have deposit initial?:");
            char resp = char.Parse(Console.ReadLine());
            double value;

            if (resp == 's')
            {
                Console.Write("Enter with the deposit initial:");
                value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                C1.Deposit(value);
                Console.WriteLine($"Dados da conta:\n{C1}");
            }
            else if (resp == 'n')
            {
                Console.WriteLine($"Dados da conta:\n{C1}");
            }
            else
            {
                Console.WriteLine("Incorrect Option");
            }

            Console.WriteLine("Enter the value for the deposit: ");
            value = double.Parse(Console.ReadLine());
            C1.Deposit(value);
            Console.WriteLine($"Dados da conta atualizados:\n{C1}");

            Console.WriteLine("Enter the value for the saque: ");
            value = double.Parse(Console.ReadLine());
            C1.Saque(value);
            Console.WriteLine($"Dados da conta atualizados:\n{C1}");
        }
    }
}
