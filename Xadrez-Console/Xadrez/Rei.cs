using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
