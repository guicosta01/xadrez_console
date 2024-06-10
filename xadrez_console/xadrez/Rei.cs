using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor){ //pega o construtor da superclasse
        }

        public override string ToString(){
            return "R";
        }
    }
}