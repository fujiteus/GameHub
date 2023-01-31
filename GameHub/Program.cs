using System;

namespace gameHub
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoDoUsuario;
            string prosseguir;

            do
            {
                MenuPrincipal.saudacao();
                opcaoDoUsuario = Console.ReadLine();
                if (opcaoDoUsuario == "2")
                {
                    MenuPrincipal.regras();
                    MenuPrincipal.voltarAoMenu();
                    prosseguir = Console.ReadLine();
                    Console.Clear();
                }
                else if (opcaoDoUsuario == "1")
                {
                    Console.Clear();
                    int nJogada = 0, player = 1, linha, coluna, vencedor;
                    string sLinha, sColuna;
                    bool continuarJogo = true;
                    Tabuleiro jogo = new Tabuleiro();
                    while (nJogada < 9 && continuarJogo)
                    {
                        Tabuleiro.vezDeQuem(player);
                        jogo.imprimirTabuleiro();
                        Console.Write("Escolha a linha (1 - 3): ");
                        sLinha = Console.ReadLine();
                        Console.Write("Escolha a coluna (1 - 3): ");
                        sColuna = Console.ReadLine();
                        Console.WriteLine("---------------------------------------");
                        if (int.TryParse(sLinha, out linha) && int.TryParse(sColuna, out coluna) && linha <=3 && coluna <=3 && linha >= 1 && coluna >= 1)
                        {
                            if (jogo.jogadaNaoFoi(linha-1, coluna-1))
                            {
                                jogo.jogada(player, linha-1, coluna-1);
                                player += Convert.ToInt32(Math.Cos(nJogada * Math.PI));
                                nJogada++;
                                continuarJogo = jogo.continuarJogo(linha-1, coluna-1);
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Essa jogada já foi, tente novamente");
                                Console.WriteLine("---------------------------------------");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Por favor, selecione uma jogada válida");
                            Console.WriteLine("---------------------------------------");
                        }

                    }
                    jogo.imprimirTabuleiro();
                    Console.WriteLine("JOGO ENCERRADO!");
                    Console.WriteLine("---------------------------------------");
                    MenuPrincipal.voltarAoMenu();
                    prosseguir = Console.ReadLine();
                    Console.Clear();
                }
            } while (opcaoDoUsuario != "0");
            MenuPrincipal.sair();
        }

    }
}