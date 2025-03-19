namespace JogoDosDados.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

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
