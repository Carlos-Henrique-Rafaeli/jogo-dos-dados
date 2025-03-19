namespace JogoDosDados.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            IniciarJogo();

            Console.Write("\nDeseja jogar novamente? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }

    static void IniciarJogo()
    {
        bool jogoEmAndamento = true;

        while (jogoEmAndamento)
        {
            string quemEstaJogando = "Usuário";

            ExibirCabecalho(quemEstaJogando);

            string resultado = JogoDosDados.JogarRodada(quemEstaJogando);

            ExibirValorSorteado();

            if (resultado == "Jogador Avanço")
                EventoAvancar(quemEstaJogando);

            else if (resultado == "Jogador Recuo")
                EventoRecuo(quemEstaJogando);

            ExibirPosicao();

            if (resultado == "Jogador Venceu")
            {
                EventoGanhar(quemEstaJogando);
                jogoEmAndamento = false;
                continue;
            }

            IrParaProximaRodada();

            quemEstaJogando = "Computador";

            ExibirCabecalho(quemEstaJogando);

            resultado = JogoDosDados.JogarRodada(quemEstaJogando);

            ExibirValorSorteado();

            if (resultado == "Computador Avanço")
                EventoAvancar(quemEstaJogando);

            else if (resultado == "Computador Recuo")
                EventoRecuo(quemEstaJogando);

            ExibirPosicao();

            if (resultado == "Computador Venceu")
            {
                EventoGanhar(quemEstaJogando);
                jogoEmAndamento = false;
                continue;
            }

            IrParaProximaRodada();
        }
    }

    static void EventoAvancar(string quemAvancou)
    {
        if (quemAvancou == "Usuário")
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
            Console.WriteLine($"Você avançou para a posição : {JogoDosDados.posicaoJogador}");
            Console.WriteLine("------------------------------------------------\n");
        }
        else
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
            Console.WriteLine($"O Computador avançou para a posição : {JogoDosDados.posicaoComputador}");
            Console.WriteLine("------------------------------------------------\n");
        }
    }

    static void EventoGanhar(string quemGanhou)
    {
        Console.WriteLine();

        if (quemGanhou == "Usuário")
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Parabéns, você alcançou a linha de chegada!");
            Console.WriteLine("------------------------------------------------");
        }
        else
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Que pena! O Computador alcançou a linha de chegada!");
            Console.WriteLine("------------------------------------------------");
        }
    }

    static void EventoRecuo(string quemRecuou)
    {
        if (quemRecuou == "Usuário")
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
            Console.WriteLine($"Você recuou para a posição : {JogoDosDados.posicaoJogador}");
            Console.WriteLine("------------------------------------------------\n");
        }
        else
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
            Console.WriteLine($"O Computador recuou para a posição : {JogoDosDados.posicaoComputador}");
            Console.WriteLine("------------------------------------------------\n");
        }
    }

    static void IrParaProximaRodada()
    {
        Console.WriteLine("\nPressione ENTER para ir para próxima rodada...");
        Console.ReadLine();
    }

    static void ExibirValorSorteado()
    {
        Console.WriteLine($"\nO valor sorteado foi: {JogoDosDados.resultado}\n");
    }

    static void ExibirPosicao()
    {
        Console.WriteLine($"Você está na posição {JogoDosDados.posicaoJogador} de {JogoDosDados.limiteLinhaChegada}");
        Console.WriteLine($"O Computador está na posição {JogoDosDados.posicaoComputador} de {JogoDosDados.limiteLinhaChegada}");
    }

    static void ExibirCabecalho(string quemVaiJogar)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Rodada do {quemVaiJogar}");
        Console.WriteLine("------------------------------------------------");

        Console.Write("\nPressione ENTER para lançar o dado...");
        Console.ReadLine();
    }
    
}
