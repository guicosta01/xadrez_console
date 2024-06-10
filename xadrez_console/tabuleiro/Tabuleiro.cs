using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    public class Tabuleiro(int linhas, int colunas)
    {
        public int linhas { get; set; } = linhas;
        public int colunas { get; set; } = colunas;
        private Peca[,] pecas = new Peca[linhas, colunas];
    }
}