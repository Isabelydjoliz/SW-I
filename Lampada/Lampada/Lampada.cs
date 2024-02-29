using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; }
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        public void ligar()
        {
            Ligada = true;
        }

        public void desligar()
        {
            Ligada = false;
        }

        public bool estaligada()
        {
            return Ligada;
        }
    }
}
