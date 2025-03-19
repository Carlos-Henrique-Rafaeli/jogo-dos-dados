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
            bool jogoEmAndamento = true;

            while (jogoEmAndamento)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("------------------------------------------------");


                Console.Write("\nPressione ENTER para lançar o dado...");
                Console.ReadLine();

                Random geradorDeNumeros = new Random();

                int resultado = geradorDeNumeros.Next(1, 7);

                Console.WriteLine($"\nO valor sorteado foi {resultado}!\n");

                posicaoJogador += resultado;

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
                    jogoEmAndamento = false;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Parabéns, você alcançou a linha de chegada!");
                    Console.WriteLine("------------------------------------------------");
                }
                else
                    Console.WriteLine($"Você está na posição {posicaoJogador} de {limiteLinhaChegada}!");

                Console.ReadLine();
            }

            Console.Write("\nDeseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
