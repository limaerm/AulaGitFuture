using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ContaPoupanca:ContaCorrente
    {
        public ContaPoupanca()
        {
            Pessoa = new Pessoa();
        }
        public DateTime Vencimento { get; set; }

        public Pessoa Titular { get; set; }

        public Double Rentabilidade { get; set; }

    }
}
