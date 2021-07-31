using System;

namespace Entidades
{
    public class ContaCorrente
    {
        public ContaCorrente()
        {
            Pessoa = new Pessoa();
        }

        public String Agencia { get; set; }

        public String NumeroConta { get; set; }

        public String Digito { get; set; }

        public Double Saldo { get; set; }

        

        public Pessoa Pessoa { get; set; }

        public String OperacaoFinanceira(Double valor, TipoMovimentoConta tipo)
        {
            String mensagem;
            if (valor > 0)
            {
                if (tipo == TipoMovimentoConta.Saque)
                {
                    Saldo -= valor;
                    mensagem = "Saque de " + valor.ToString("C") + " realizado com sucesso";

                }
                else
                {

                    Saldo += valor;

                    
                    mensagem = "Depoisto de " + valor.ToString("C") + " realizado com sucesso";
                }

             }
             else
                mensagem = "Valor para " + ((tipo == TipoMovimentoConta.Saque) ? "Saque " : "Deposito ") + " inválido ";

            return mensagem;
        }

    }
}
