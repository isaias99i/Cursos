﻿using System;
using System.Globalization;

namespace Produto {
    class Program {
        static void Main(string[] args) {

            Produto p = new("TV", 500.0, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}