using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab){
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j)==null){
                        Console.Write("-");
                    }
                    else{
                        // Access the board position at (i, j) and print it
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}