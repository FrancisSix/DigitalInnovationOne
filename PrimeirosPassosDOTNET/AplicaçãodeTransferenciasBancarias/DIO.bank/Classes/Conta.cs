using System;
namespace DIO.bank
{

    public class Conta
    {
        private TipoConta TipoConta{get; set; }
        
        private double Saldo{ get; set; }

        private double Credito{ get; set; }

        private string Nome{ get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {

            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente! ");

                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo Atual da Conta de {0} é {1}",this.Nome, this.Saldo);

            return true;
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo Atual da Conta de {0} é {1}",this.Nome, this.Saldo);

        }
        public void Tranferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }

        }
        public override string ToString()
        {
            string retorno;
        }
    }
}