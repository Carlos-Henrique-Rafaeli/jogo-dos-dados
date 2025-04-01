namespace JogoDosDados.ConsoleApp;

class Menu
{
    public void ExibirCabecalho(string nomeJogador)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Rodada do {nomeJogador}");
        Console.WriteLine("------------------------------------------------");

        Console.Write("\nPressione ENTER para lançar o dado...");
        Console.ReadLine();
    }

    public void ExibirValorSorteado(int resultado)
    {
        Console.WriteLine($"\nO valor sorteado foi: {resultado}");
    }

    public void ExibirRodadaBonus(string nomeJogador)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Rodada Bônus");
        Console.WriteLine($"O {nomeJogador} joga mais uma vez!");
        Console.WriteLine("------------------------------------------------");
    }
    public void ExibirEventoAvancar(string nomeJogador, int posicaoNova)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
        Console.WriteLine($"O {nomeJogador} avançou para a posição : {posicaoNova}");
        Console.WriteLine("------------------------------------------------");
    }
    public void ExibirEventoRecuar(string nomeJogador, int posicaoNova)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
        Console.WriteLine($"O {nomeJogador} recuou para a posição : {posicaoNova}");
        Console.WriteLine("------------------------------------------------");
    }

    public void ExibirVencedor(string nomeJogador)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"O {nomeJogador} alcançou a linha de chegada!");
        Console.WriteLine("------------------------------------------------");
    }

    public void ExibirProximaRodada()
    {
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para ir para próxima rodada...");
        Console.ReadLine();
    }

    public void ExibirPosicao(string nomeJogador, int posicaoJogador, int linhaChegada)
    {
        Console.WriteLine();
        Console.WriteLine($"O {nomeJogador} está na posição {posicaoJogador} de {linhaChegada}");
    }


}