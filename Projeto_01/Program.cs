using Entidades;
using System;

namespace Projeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double valores = 0;
            string mensagem = String.Empty;

            ContaCorrente contaCorrente = PreencherDadosContaCorrente();
            ContaPoupanca contaPoupanca = PreencherDadosContaPoupanca();

            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("   CONTA CORRENTE                            ");
            System.Console.WriteLine("---------------------------------------------");

            System.Console.WriteLine("Agência: " + contaCorrente.Agencia.ToString());
            System.Console.WriteLine("Conta: " + contaCorrente.NumeroConta.ToString() + " - " + contaCorrente.Digito.ToString());
            System.Console.WriteLine("Saldo: " + contaCorrente.Saldo.ToString("C"));


            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("   DADOS CORRENTISTA                         ");
            System.Console.WriteLine("---------------------------------------------");

            System.Console.WriteLine("CPF: " + contaCorrente.Pessoa.Cpf.ToString());
            System.Console.WriteLine("Nome: " + contaCorrente.Pessoa.Nome.ToString());
            System.Console.WriteLine("Fone: " + contaCorrente.Pessoa.Telefone.ToString());
            System.Console.WriteLine("Celular: " + contaCorrente.Pessoa.Celular.ToString());
            System.Console.WriteLine("e-Mail: " + contaCorrente.Pessoa.Email.ToString());

            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("   ENDEREÇO                                  ");
            System.Console.WriteLine("---------------------------------------------");

            System.Console.WriteLine("Rua: " + contaCorrente.Pessoa.Lougradouro.ToString() + " Número: " + contaCorrente.Pessoa.Numero.ToString()+ " Compl: " + contaCorrente.Pessoa.Complemento.ToString());
            System.Console.WriteLine("CEP: " + contaCorrente.Pessoa.Cep.ToString()+ " Estado: " + contaCorrente.Pessoa.Estado.ToString() + " UF: " + contaCorrente.Pessoa.UF.ToString());
            System.Console.WriteLine("Cidade: " + contaCorrente.Pessoa.Cidade.ToString());

            System.Console.WriteLine("");


            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("   POUPANÇA                                  ");
            System.Console.WriteLine("---------------------------------------------");

            System.Console.WriteLine("Agência: " + contaPoupanca.Agencia.ToString());
            System.Console.WriteLine("Conta Poupança: " + contaPoupanca.NumeroConta.ToString() + " / " + contaPoupanca.Digito.ToString());
            System.Console.WriteLine("Saldo: " + contaPoupanca.Saldo.ToString("C"));
            System.Console.WriteLine("Aniversário Rendimento: " + contaPoupanca.Vencimento.ToString("d"));
            System.Console.WriteLine("Rentabilidade : " + contaPoupanca.Rentabilidade.ToString("p"));


            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("   DADOS TITULAR                             ");
            System.Console.WriteLine("---------------------------------------------");

            System.Console.WriteLine("CPF: " + contaPoupanca.Titular.Cpf.ToString());
            System.Console.WriteLine("Nome: " + contaPoupanca.Titular.Nome.ToString());
            System.Console.WriteLine("Fone: " + contaPoupanca.Titular.Telefone.ToString());
            System.Console.WriteLine("Celular: " + contaPoupanca.Titular.Celular.ToString());
            System.Console.WriteLine("e-Mail: " + contaPoupanca.Titular.Email.ToString());

            System.Console.WriteLine("");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("   SALDO ANTERIOR                             ");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("SALDO CONTA CORRENTE: " + contaCorrente.Saldo.ToString("c"));
            System.Console.WriteLine("SALDO POUPANÇA      : " + contaPoupanca.Saldo.ToString("c"));

            System.Console.WriteLine("---------------------------------------------");

            valores = 2500.00;
            System.Console.WriteLine("SAQUE CONTA CORRENTE: " + valores.ToString("c"));
            mensagem = contaCorrente.OperacaoFinanceira(2500.00, TipoMovimentoConta.Saque);
            System.Console.WriteLine(mensagem);

            System.Console.WriteLine("");

            valores = 7000.00;
            System.Console.WriteLine("DEPÓSITO POUPANÇA: " + valores.ToString("c"));
            mensagem = contaPoupanca.OperacaoFinanceira(7000.00, TipoMovimentoConta.Deposito);
            System.Console.WriteLine(mensagem);

            System.Console.WriteLine("");

            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("   SALDO ATUAL                               ");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("SALDO CONTA CORRENTE: " + contaCorrente.Saldo.ToString("c"));
            System.Console.WriteLine("SALDO POUPANÇA      : " + contaPoupanca.Saldo.ToString("c"));

        }


        public static ContaCorrente PreencherDadosContaCorrente()
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Agencia = "0758";
            contaCorrente.NumeroConta = "458854";
            contaCorrente.Digito = "5";
            contaCorrente.Saldo = 10000.00;
            contaCorrente.Pessoa = PreencherDadosCorrentista();
            
            return contaCorrente;

        }
        public static ContaPoupanca PreencherDadosContaPoupanca()
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaPoupanca.Agencia = "0758";
            contaPoupanca.NumeroConta = "458854";
            contaPoupanca.Digito = "100";
            contaPoupanca.Saldo = 50000.00;
            contaPoupanca.Vencimento = Convert.ToDateTime("15/08/2021");
            contaPoupanca.Rentabilidade = 1.60;
            contaPoupanca.Titular = PreencherDadosTitular();
            return contaPoupanca;

        }

        public static Pessoa PreencherDadosCorrentista()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Maria J da Silva";
            pessoa.Cpf = "122.577.855-44";
            pessoa.Telefone = "(11) 2255-5755";
            pessoa.Celular = "(11) 99978-5587";
            pessoa.Email = "teste@gmail.com";
            pessoa.Lougradouro = "Rua dos testes";
            pessoa.Numero = 244;
            pessoa.Complemento = "apto 31";
            pessoa.Cep = "02205-005";
            pessoa.Estado = "São Paulo";
            pessoa.UF = "SP";
            pessoa.Cidade = "São Paulo";

            return pessoa;

        }

        public static Pessoa PreencherDadosTitular()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Paulo J da Silva";
            pessoa.Cpf = "077.577.855-44";
            pessoa.Telefone = "(11) 2255-5755";
            pessoa.Celular = "(11) 99887-5587";
            pessoa.Email = "titular@gmail.com";
            pessoa.Lougradouro = "Rua dos testes";
            pessoa.Numero = 244;
            pessoa.Complemento = "apto 31";
            pessoa.Cep = "02205-005";
            pessoa.Estado = "São Paulo";
            pessoa.UF = "SP";
            pessoa.Cidade = "São Paulo";

            return pessoa;

        }
    }
}
