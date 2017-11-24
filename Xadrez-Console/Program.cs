using System;

namespace Tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));

                Tela.imprimirTabuleiro(tabuleiro);
            }
            catch(TabuleiroException e)
            {
                Console.Write(e.Message);
            }

            Console.ReadLine();
        }
    }
}