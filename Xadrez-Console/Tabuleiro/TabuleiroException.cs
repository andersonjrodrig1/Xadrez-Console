using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(String msg) : base(msg) { }
    }
}