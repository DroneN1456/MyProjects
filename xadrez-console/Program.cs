using System;
using System.Collections.Concurrent;
using System.Dynamic;
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
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando a jogada: " + partida.JogadorAtual);

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

                
            }

            catch(TabuleiroException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
