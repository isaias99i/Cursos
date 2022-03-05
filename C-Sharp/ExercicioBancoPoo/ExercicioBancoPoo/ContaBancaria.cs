using System;
using System.Globalization;
using System.Linq;

namespace ExercicioBancoPoo {
    class ContaBancaria {
        private string _titular { get; set; } 
        public int NumConta { get; private set; } //*private* set (número não pode ser alterado)
        //public bool DepositoInicial { get; private set; }
        public double Saldo { get; private set; }//*private set (pois só pode ser alterado por método)
        public ContaBancaria(int numConta, string titular) {
            NumConta = numConta;
            Titular = titular;
        }
        public ContaBancaria(int NumConta, string titular, double depositoInicial) : this(NumConta, titular) {
            Deposito(depositoInicial);
        }
        public string Titular {
            get { return _titular; }
            set {
                if (value != null && value.Length > 1) {
                    _titular = value;
                }
            }
        }
        public void Deposito(double valor) {
            Saldo += valor;
        }
        public void Saque(double valor) {
            Saldo -= valor + 5;
        }
        public override string ToString() => $"{NumConta}, Titular: {_titular}, Saldo: R$ {Saldo:F2}.";
    }
}
