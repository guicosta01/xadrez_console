using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    public class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }         
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //metodo para acessar a peça
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}