// See https://aka.ms/new-console-template for more informatio
using tabuleiro;
using xadrez_console;
using xadrez;

PosicaoXadrez pos = new PosicaoXadrez('c' , 7);

Console.WriteLine(pos);

Console.WriteLine(pos.toPosicao());

Console.ReadLine();