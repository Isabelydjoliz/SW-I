﻿using FolhaDePagamento;

namespace FolhaPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pagamento pagamento = new Pagamento();

            Console.WriteLine(pagamento.Pag());
        }
    }
}