namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // INSTÂNCIA DE UM OBJETO A PARTIR DE UMA CLASSE EXISTENTE
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            //ACESSANDO UM ATRIBUTI PÚBLICO DO OBJETO
            lampada1.Ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "Vermelha";

            lampada2.Ligada = false;
            lampada2.Potencia = 100;
            lampada2.Cor = "Azul";

            //MOSTRANDO NA TELA
            Console.WriteLine("ESSA É A LÂMPADA 1");
            Console.WriteLine("A lâmpada está ligada? " + lampada1.Ligada);
            Console.WriteLine("A lâmpada tem qual potência? " + lampada1.Potencia);
            Console.WriteLine("A lâmpada é de qual cor? " + lampada1.Cor);
            Console.WriteLine("************************************************");

            Console.WriteLine("ESSA É A LÂMPADA 2");
            Console.WriteLine("A lâmpada está ligada? " + lampada2.Ligada);
            Console.WriteLine("A lâmpada tem qual potência? " + lampada2.Potencia);
            Console.WriteLine("A lâmpada é de qual cor? " + lampada2.Cor);


            Console.WriteLine("Cor da lâmpada 1: " + lampada1.Cor);
            Console.WriteLine("Cor da lâmpada 1: " + lampada1.Cor);


        }
    }
}