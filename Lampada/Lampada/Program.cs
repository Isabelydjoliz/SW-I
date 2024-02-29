namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // INSTÂNCIA DE UM OBJETO A PARTIR DE UMA CLASSE EXISTENTE
            Lampada lampada1 = new Lampada();

            //chmando o método para ligar a lamp1
            lampada1.ligar();

            //chamando o método para verificar se a lamp1 está ligada
            Console.WriteLine("a lâmpada está ligada? " + lampada1.estaligada());


        }
    }
}