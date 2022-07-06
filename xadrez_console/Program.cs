// See https://aka.ms/new-console-template for more informatio
using tabuleiro;
using xadrez_console;
using xadrez;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
    tab.colocarPeca(new Rei(tab,Cor.Preta), new Posicao(5, 5));
    tab.colocarPeca(new Torre(tab,Cor.Branca), new Posicao(4, 4));
    tab.colocarPeca(new Rei(tab,Cor.Branca), new Posicao(6, 6));
    
    Tela.imprimirTabuleiro(tab);


}catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();