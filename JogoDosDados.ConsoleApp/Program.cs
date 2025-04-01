namespace JogoDosDados.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

        Console.Write("Informe seu nome: ");
        string nomeUsuario = Console.ReadLine()!;

        while (true)
        {
            Jogador usuario = new Jogador(nomeUsuario);
            Jogador computador = new Jogador("ChatGPT");

            Jogador[] jogadores = [usuario, computador];

            Dado dado = new Dado();
            Menu menu = new Menu();

            bool estaJogando = true;

            while (estaJogando)
            {
                for (int i = 0; i < jogadores.Length; i++)
                {
                    Jogador jogadorAtual = jogadores[i];

                    string nome = jogadorAtual.nome;

                    menu.ExibirCabecalho(nome);
                    
                    int resultado = dado.Sortear();

                    menu.ExibirValorSorteado(resultado);

                    jogadorAtual.Avancar(resultado);

                    if (jogadorAtual.EstaNaPosicaoAvancarExpecial())
                    {
                        jogadorAtual.AvancarExpecial();
                        menu.ExibirEventoAvancar(nome, jogadorAtual.posicao);
                    }
                    
                    else if (jogadorAtual.EstaNaPosicaoRecuarExpecial())
                    {
                        jogadorAtual.RecuarExpecial();
                        menu.ExibirEventoRecuar(nome, jogadorAtual.posicao);
                    }
                    
                    if (jogadorAtual.UltrapassouLinhaDeChegada(limiteLinhaChegada))
                    {
                        menu.ExibirVencedor(nome);
                        estaJogando = false;
                        break;
                    }
                    
                    if (resultado == 6)
                    {
                        menu.ExibirRodadaBonus(nome);
                        i--;
                    }

                    menu.ExibirPosicao(nome, jogadorAtual.posicao, limiteLinhaChegada);
                    menu.ExibirProximaRodada();

                }
            }

            Console.Write("\nDeseja jogar novamente? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
