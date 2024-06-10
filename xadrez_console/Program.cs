
using System;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

try{
    Tabuleiro tab = new(8, 8);
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));


    Tela.imprimirTabuleiro(tab);
    // PosicaoXadrez pos = new PosicaoXadrez('a', 1);
    // Console.WriteLine(pos.toPosicao());

}
catch (TabuleiroException e){
    Console.Write(e.Message);
}

