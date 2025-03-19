namespace JogoDosDados.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

        int[] casasAvanco = [5, 10, 15, 25];
        int[] casasRecuo = [7, 13, 20];

        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;

            bool jogoEmAndamento = true;

            while (jogoEmAndamento)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Rodada do Usuário");
                Console.WriteLine("------------------------------------------------");

                Console.Write("\nPressione ENTER para lançar o dado...");
                Console.ReadLine();

                int resultadoJogador = SortearNumero();

                Console.WriteLine($"\nO valor sorteado foi {resultadoJogador}!\n");

                posicaoJogador += resultadoJogador;

                if (casasAvanco.Contains(posicaoJogador))
                {
                    posicaoJogador += 3;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
                    Console.WriteLine($"Você avançou para a posição : {posicaoJogador}");
                    Console.WriteLine("------------------------------------------------\n");
                }
                else if (casasRecuo.Contains(posicaoJogador))
                {
                    posicaoJogador -= 2;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
                    Console.WriteLine($"Você Recuou para a posição : {posicaoJogador}");
                    Console.WriteLine("------------------------------------------------\n");
                }

                if (posicaoJogador >= limiteLinhaChegada)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Parabéns, você alcançou a linha de chegada!");
                    Console.WriteLine("------------------------------------------------");
                    
                    jogoEmAndamento = false;
                    continue;
                }
                else
                    Console.WriteLine($"Você está na posição {posicaoJogador} de {limiteLinhaChegada}!");

                Console.WriteLine("\n------------------------------------------------");
                Console.WriteLine("Rodada do Computador");
                Console.WriteLine("------------------------------------------------");
                Console.Write("\nPressione ENTER para lançar o dado...");
                Console.ReadLine();

                int resultadoComputador = SortearNumero();

                Console.WriteLine($"\nO valor sorteado foi {resultadoComputador}!\n");

                posicaoComputador += resultadoComputador;

                if (casasAvanco.Contains(posicaoComputador))
                {
                    posicaoJogador += 3;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
                    Console.WriteLine($"O Computador avançou para a posição : {posicaoComputador}");
                    Console.WriteLine("------------------------------------------------\n");
                }
                else if (casasRecuo.Contains(posicaoComputador))
                {
                    posicaoComputador -= 2;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
                    Console.WriteLine($"O Computador Recuou para a posição : {posicaoComputador}");
                    Console.WriteLine("------------------------------------------------\n");
                }

                if (posicaoComputador >= limiteLinhaChegada)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Que pena, O Computador alcançou a linha de chegada!");
                    Console.WriteLine("------------------------------------------------");

                    jogoEmAndamento = false;
                    continue;
                }
                else
                    Console.WriteLine($"O Computador está na posição {posicaoComputador} de {limiteLinhaChegada}!");

                Console.ReadLine();
            }

            Console.Write("\nDeseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }

    static int SortearNumero()
    {
        Random geradorDeNumeros = new Random();

        int resultado = geradorDeNumeros.Next(1, 7);

        return resultado;
    }
}
