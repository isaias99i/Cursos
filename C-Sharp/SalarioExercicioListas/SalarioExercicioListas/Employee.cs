using System;
using System.Globalization;
using System.Collections.Generic;
namespace SalarioExercicioListas {
    class Employee {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Employee(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncreaseSalary(double percent) {
            Salario += Salario * percent / 100.0;
        }

        public override string ToString() => $"{Id}, {Nome}, {Salario:F2}";
    }
}
