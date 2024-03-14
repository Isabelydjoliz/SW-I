using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        private float saldo_limite;

        private string? Num_conta { get; set; }
        private float Saldo { get; set; }
        private float Limite { get; set; }

        public float consulta_saldo()
        { 
            return Saldo;
        }
        public void deposito(float valor_deposito)
        {
            Saldo += valor_deposito;
        }

        public void sacar(float valor_saque)
        {
            if(valor_saque > saldo_limite)
            {
                Console.WriteLine("VOCE NÃO TEM SALDO SUFICIENTE");
            }
            else
            {
                Saldo -= valor_saque;
                Console.WriteLine("Agora seu saldo é de R$" + consulta_saldo());
            }
        }

        public void ajustar_limite(float valor_limite)
        {
            Limite = valor_limite;
            Console.WriteLine("Agora seu limite é de R$" + Limite);
            saldo_limite = Limite + Saldo;
            Console.WriteLine("Seu saldo + Limite é de R$:" + saldo_limite);
        }
    }
}
