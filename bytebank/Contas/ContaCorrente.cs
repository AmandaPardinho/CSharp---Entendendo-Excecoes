using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; private set; }

        public static float TaxaOperacao { get; private set; }

        private int _numeroAgencia;
        public int NumeroAgencia
        {
            get { return _numeroAgencia; }
            private set
            {
                if(value > 0)
                {
                    _numeroAgencia = value;
                }
            }
        }

        public string Conta { get; set; }

        private double saldo = 100;

        public Clientes Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo insuficiente para a operação!");
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            try
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public ContaCorrente(int _numeroAgencia, string numeroConta)
        {
            NumeroAgencia = _numeroAgencia;
            Conta = numeroConta;
            if(_numeroAgencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(_numeroAgencia));
            }
            /*try
            {
                TaxaOperacao = 30 / TotalContasCriadas;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro! Não é possível fazer uma divisão por zero");
            }*/
            TotalContasCriadas++;
        }
    }
}
