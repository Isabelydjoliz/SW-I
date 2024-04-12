namespace Exercício3_Album
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando número de fotos por página");
            Console.WriteLine("");

            Fotos album = new Fotos();

            Console.WriteLine(album.NumeroDePaginas());

        }
    }
}