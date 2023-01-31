using System;
class Tabuleiro
{
    private int[,] _tabuleiro = {  { 0, 0, 0, 0}, 
                                   { 0, 0, 0, 0}, 
                                   { 0, 0, 0, 0},
                                   { 0, 0, 0, 0} };
    public void jogada(int player, int linha, int coluna)
    {
        if (player == 1)
        {
            _tabuleiro[linha, coluna] = 5;
        }
        else if (player == 2)
        {
            _tabuleiro[linha, coluna] = 7;
        }
    }
    public int verificarVitoria(int linha, int coluna)
    {
        int horizontal = _tabuleiro[linha, 0] + _tabuleiro[linha, 1] + _tabuleiro[linha, 2];
        int vertical = _tabuleiro[0, coluna] + _tabuleiro[1, coluna] + _tabuleiro[2, coluna];
        int diagonalPrincipal = 0;
        int diagonalSecundaria = 0;
        if (linha == coluna) { diagonalPrincipal = _tabuleiro[0, 0] + _tabuleiro[1, 1] + _tabuleiro[2, 2]; }
        if (linha == 2 - coluna) { diagonalSecundaria = _tabuleiro[0, 2] + _tabuleiro[1, 1] + _tabuleiro[2, 0]; }
        if ((horizontal % 5 == 0 && horizontal / 5 == 3) || (vertical % 5 == 0 && vertical / 5 == 3) || (diagonalPrincipal % 5 == 0 && diagonalPrincipal / 5 == 3) || (diagonalSecundaria % 5 == 0 && diagonalSecundaria / 5 == 3))
        {
            return 1;
        }
        else if ((horizontal % 7 == 0 && horizontal / 7 == 3) || (vertical % 7 == 0 && vertical / 7 == 3) || (diagonalPrincipal % 7 == 0 && diagonalPrincipal / 7 == 3) || (diagonalSecundaria % 7 == 0 && diagonalSecundaria / 7 == 3))
        {
            return 2;
        }
        else { return 0; }
    }
    public void imprimirTabuleiro()
    {
        Console.WriteLine("   1|2|3");
        Console.WriteLine("--------");
        for (int i = 0; i < 5; i++) 
        {
            if (i % 2 == 0)
            {
                Console.Write(i/2 + 1 + "| ");
                for (int j = 0; j < 5; j++) 
                {
                    if (j % 2 == 0)
                    {
                        if (_tabuleiro[i /2, j/2] == 5)
                        {
                            Console.Write("X");
                        }
                        else if (_tabuleiro[i/2, j/2] == 7)
                        {
                            Console.Write("O");
                        }
                        else { Console.Write(" "); }
                    }
                    else { Console.Write("|"); }
                }
                Console.WriteLine("");
            }
            else { Console.WriteLine(" | -----"); }
        }
        Console.WriteLine("---------------------------------------");
    }
    public bool jogadaNaoFoi(int linha, int coluna)
    {
        if (_tabuleiro[linha, coluna] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool continuarJogo(int linha, int coluna) 
    {
        int continuar = verificarVitoria(linha, coluna);
        if (continuar != 0)
        {
            return false; 
        }
        else 
        {

            return true;
        }
    }
    public static void vezDeQuem(int player) 
    {
        Console.WriteLine("Agora é a vez do Player "+player);
        Console.WriteLine("---------------------------------------");
    }
    public static void vezDeQuem(string player)
    {
        Console.WriteLine("Agora é a vez de" + player);
        Console.WriteLine("---------------------------------------");
    }


}

