namespace Exercício2_Site
{
    internal class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Isabely";
            pessoa.Idade = 16;
            pessoa.CPF = "313.166.558.06";
            pessoa.Sexo = 'F';
            pessoa.Altura = 1.60;

            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Idade: " + pessoa.Idade);
            Console.WriteLine("Cpf: " + pessoa.CPF);
            Console.WriteLine("Sexo: " + pessoa.Sexo);
            Console.WriteLine("Altura: " + pessoa.Altura);
        }
    }
}