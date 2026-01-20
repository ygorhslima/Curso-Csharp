using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Ex025
{
    public class ContaBancaria(string titular)
    {
        public string Titular { get; private set; } = titular;
        public double Saldo { get; private set; } = 0;

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar a operação.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado. Saldo atual: R$ {Saldo:F2}");
            }
        }
    }
}