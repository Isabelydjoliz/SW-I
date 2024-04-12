using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3_Album
{
    internal class Fotos
    {
        public double NumeroFotos { get; set; }
        public double FotosPagina { get; set; }
        public double Restante { get; set; }

        public double Div { get; set; }

        public string NumeroDePaginas()
        {

            Console.WriteLine("Digite quantas fotos você vai usar");
            NumeroFotos = Convert.ToDouble(Console.ReadLine());
            FotosPagina = 2;

            Restante = NumeroFotos % FotosPagina;
            Div = (NumeroFotos / FotosPagina) - 0.5;

            if (Restante == 1)
            {
                return "Com duas fotos por página você terá " + Div + " páginas com fotos, e irá sobrar " + Restante + " fotos";
            }
            else
            {
                return "Com duas fotos por página você terá " + NumeroFotos / FotosPagina + " páginas com fotos";
            }
        }
    }
}