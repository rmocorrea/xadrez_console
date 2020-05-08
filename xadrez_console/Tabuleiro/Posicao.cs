﻿namespace tabuleiro
{
    class Posicao
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linhas = linha;
            this.colunas = coluna;
        }

        public override string ToString()
        {
            return linhas
                + ", "
                + colunas;
        }
    }
}
