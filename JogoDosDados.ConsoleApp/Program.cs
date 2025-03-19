namespace JogoDosDados.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Jogo dos Dados");
            Console.WriteLine("---------------------------------");

            Console.Write("\nPressione ENTER para lançar o dado...");
            Console.ReadLine();

            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            Console.WriteLine($"\nO valor sorteado foi {resultado}!");

            Console.Write("\nDeseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
