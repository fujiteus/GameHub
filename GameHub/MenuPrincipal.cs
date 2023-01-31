using System;
class MenuPrincipal
{
    public static void saudacao()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("### JOGO DA VELHA ###");
        Console.WriteLine("---------------------");
        Console.WriteLine("");
        Console.WriteLine("Selecione a Opção desejada");
        Console.WriteLine("1 - Novo jogo");
        Console.WriteLine("2 - Como jogar");
        //Console.WriteLine("3 - Ver ranking");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");
    }
    public static void regras()
    {
        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine("Como jogar o jogo da velha:");
        Console.WriteLine("1- Cada jogador, em sua vez, deverá especificar uma linha e uma coluna");
        Console.WriteLine("2- As posições são os números 1, 2 ou 3 de acordo com as posições indicadas");
        Console.WriteLine("3- Não é permitido sobrescrever uma jogada já feita em rodada anterior ou outros números");
        Console.WriteLine("4- A rodada começará pelo player 1 que será o X");
        Console.WriteLine("----------------------------------------------------------------------------------------");
    }
    public static void sair()
    {
        Console.WriteLine("Obrigado, e até a próxima!");
    }
    public static void voltarAoMenu()
    {
        Console.Write("Pressione qualquer tecla para voltar ao Menu Principal: ");
    }
    public static void ehAnonimo()
    {
        Console.WriteLine("Deseja fazer login ou jogar anônimo?");
        Console.WriteLine("1 - Fazer login de usuário");
        Console.WriteLine("2 - Jogar anônimo");
        Console.Write("Opção: ");
    }
}
