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

        //Sobrecarga da funcão peca
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos){
            validarPosicao(pos);
            return peca(pos)!=null;
        }

        public void colocarPeca(Peca p, Posicao pos){

            if(existePeca(pos)){
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }

            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos){
            if(pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna>=colunas){
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos){
            if (!posicaoValida(pos)){
                throw new TabuleiroException("Posicao invalida");
            }
        }

    }
}