namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule a área do quadrado/retângulo");

            Area xyz = new Area();

            Console.WriteLine(xyz.Calcular());

            Console.WriteLine(xyz.Dados());
        }
    }
}