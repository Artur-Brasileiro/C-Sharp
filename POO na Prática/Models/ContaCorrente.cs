using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_na_Prática.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível!");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é: {Saldo:C}");
        }
    }
}