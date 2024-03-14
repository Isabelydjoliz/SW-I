using Banco;

namespace banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANCO DA ISA!");

            Conta conta = new Conta();
            Console.WriteLine("Seu saldo inicial é de R$" + conta.consulta_saldo());

            conta.deposito(500);
            conta.ajustar_limite(500);
            //Console.WriteLine("Seru saldo agora é de: R$" + conta.consulta_saldo());
        }
    }
}