namespace Aviao
{
    class Program
    {
        static void Main(string[] args)
        {
            Controle Aviao = new Controle();

            Aviao.Compania = "Gol";
            Aviao.Modelo = "Boing2411";
            Aviao.Acelerar(40);
            Aviao.Cima(19000);

            Console.WriteLine($"O nosso avião está a: " + Aviao.Altura + "pés, a velocidade atual é de: " + Aviao.Velocidade + "km/h. Nós somos da " + Aviao.Compania + ", e o nosso modelo atual é: " + Aviao.Modelo);
        }
    }
}