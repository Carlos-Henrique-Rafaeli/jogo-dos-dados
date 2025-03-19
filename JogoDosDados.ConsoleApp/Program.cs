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
        JogoDosDados.Resetar();
        while (true)
        {
            string quemEstaJogando;
            string resultado;
            
            while (JogoDosDados.quantidadeRodadasJogador > 0)
            {
                quemEstaJogando = "Usuário";

                ExibirCabecalho(quemEstaJogando);

                resultado = JogoDosDados.JogarRodada(quemEstaJogando);

                ExibirValorSorteado(quemEstaJogando);

                if (resultado == "Jogador Avanço")
                    EventoAvancar(quemEstaJogando);

                else if (resultado == "Jogador Recuo")
                    EventoRecuo(quemEstaJogando);

                ExibirPosicao();

                if (resultado == "Jogador Venceu")
                {
                    EventoGanhar(quemEstaJogando);
                    return;
                }

                JogoDosDados.quantidadeRodadasComputador = 1;
                IrParaProximaRodada();
            }
            
            while (JogoDosDados.quantidadeRodadasComputador > 0)
            {
                quemEstaJogando = "Computador";

                ExibirCabecalho(quemEstaJogando);

                resultado = JogoDosDados.JogarRodada(quemEstaJogando);

                ExibirValorSorteado(quemEstaJogando);

                if (resultado == "Computador Avanço")
                    EventoAvancar(quemEstaJogando);

                else if (resultado == "Computador Recuo")
                    EventoRecuo(quemEstaJogando);

                ExibirPosicao();

                if (resultado == "Computador Venceu")
                {
                    EventoGanhar(quemEstaJogando);
                    return;
                }

                JogoDosDados.quantidadeRodadasJogador = 1;
                IrParaProximaRodada();
            }
        }
    }

    static void EventoAvancar(string quemAvancou)
    {
        Console.WriteLine();

        if (quemAvancou == "Usuário")
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
            Console.WriteLine($"Você avançou para a posição : {JogoDosDados.posicaoJogador}");
            Console.WriteLine("------------------------------------------------");
        }
        else
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
            Console.WriteLine($"O Computador avançou para a posição : {JogoDosDados.posicaoComputador}");
            Console.WriteLine("------------------------------------------------");
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
        Console.WriteLine();

        if (quemRecuou == "Usuário")
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
            Console.WriteLine($"Você recuou para a posição : {JogoDosDados.posicaoJogador}");
            Console.WriteLine("------------------------------------------------");
        }
        else
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
            Console.WriteLine($"O Computador recuou para a posição : {JogoDosDados.posicaoComputador}");
            Console.WriteLine("------------------------------------------------");
        }
    }
    static void EventoBonus(string quemRecebeuBonus)
    {
        Console.WriteLine();

        if (quemRecebeuBonus == "Usuário")
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Rodada Bônus");
            Console.WriteLine($"Você joga mais uma vez!");
            Console.WriteLine("------------------------------------------------");
        }
        else
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("EVENTO ESPECIAL: Rodada Bônus");
            Console.WriteLine($"O Computador joga mais uma vez!");
            Console.WriteLine("------------------------------------------------");
        }
    }

    static void IrParaProximaRodada()
    {
        Console.WriteLine("\nPressione ENTER para ir para próxima rodada...");
        Console.ReadLine();
    }

    static void ExibirValorSorteado(string quemEstaJogando)
    {
        Console.WriteLine($"\nO valor sorteado foi: {JogoDosDados.resultado}");

        if (JogoDosDados.resultado == 6)
            EventoBonus(quemEstaJogando);
    }

    static void ExibirPosicao()
    {
        Console.WriteLine();

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
