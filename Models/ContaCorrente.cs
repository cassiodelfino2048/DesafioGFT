using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioGFT.ModelsDesafioGFT.Models
{
    public class ContaCorrente
    {
        private string numeroConta;
        private string titular = string.Empty;
        private decimal saldo;



        public ContaCorrente(string numeroConta, string titular)
        {
            numeroConta = numeroConta;
            titular = titular;
            saldo = 0;
            Console.WriteLine($"Conta criada para {titular}.");
        }




        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depositando R$ {valor}.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Sacando R$ {valor}.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {saldo}");
        }

    
          

    }
}