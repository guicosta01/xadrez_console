using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class PosicaoXadrez{
        public char coluna { get; set; }
        public int linha { get; set; }
    

        public PosicaoXadrez(char coluna, int linha){
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString(){
            return "" + coluna + linha;
        }

        public Posicao toPosicao(){
            return new Posicao(8 - linha, coluna - 'a');
        }

    }    
}