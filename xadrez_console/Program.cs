﻿using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Tabuleiro tab = new Tabuleiro(5, 5);

            Tela.imprimirTabuleiro(tab);
            
        }
    }
}
