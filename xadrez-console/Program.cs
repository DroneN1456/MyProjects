using System;
using System.Collections.Concurrent;
using System.Dynamic;
using System.IO;
using System.Linq.Expressions;
using tabuleiro;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validaOrigem(origem);

                        Console.Clear();
                        bool[,] posicaoPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Tela.imprimirTabuleiro(partida.tab, posicaoPossiveis);

                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                Console.Clear();
                Tela.imprimirPartida(partida);

                
            }

            catch(TabuleiroException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
