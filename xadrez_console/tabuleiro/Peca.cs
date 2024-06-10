using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; } //acessada por outras classes mas nao pode ser modificda por elas mesmo e subclases
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }
    }
}