using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_POO.Model
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal saldo;

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if(saldo > valor){
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} efetuado com sucesso. Saldo atual: {saldo:C}");
            }else{
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo:C}");
        }
    }
}