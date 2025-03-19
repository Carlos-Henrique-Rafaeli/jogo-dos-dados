namespace JogoDosDados.ConsoleApp;

public class JogoDosDados
{
    public static int posicaoJogador = 0;
    public static int posicaoComputador = 0;

    public static int resultado = 0;

    public static int[] casasAvanco = [5, 10, 15, 25];
    public static int[] casasRecuo = [7, 13, 20];

    public const int limiteLinhaChegada = 30;

    public static int quantidadeRodadasJogador = 1;
    public static int quantidadeRodadasComputador = 1;

    public static string JogarRodada(string quemVaiJogar)
    {
        resultado = SortearNumero();

        if (quemVaiJogar == "Usuário")
        {
            posicaoJogador += resultado;

            quantidadeRodadasJogador--;

            if (resultado == 6)
                quantidadeRodadasJogador++;

            if (casasAvanco.Contains(posicaoJogador))
            {
                posicaoJogador += 3;

                if (posicaoJogador >= limiteLinhaChegada)
                    return "Jogador Venceu";
                
                else
                    return "Jogador Avanço";
            }
            else if (casasRecuo.Contains(posicaoJogador))
            {
                posicaoJogador -= 2;
                return "Jogador Recuo";
            }

            if (posicaoJogador >= limiteLinhaChegada)
                return "Jogador Venceu";
        }
        
        else
        {
            posicaoComputador += resultado;

            quantidadeRodadasComputador--;

            if (resultado == 6)
                quantidadeRodadasComputador++;

            if (casasAvanco.Contains(posicaoComputador))
            {
                posicaoComputador += 3;

                if (posicaoComputador >= limiteLinhaChegada)
                    return "Computador Venceu";
                
                else
                    return "Computador Avanço";
            }
            else if (casasRecuo.Contains(posicaoComputador))
            {
                posicaoComputador -= 2;
                return "Computador Recuo";
            }

            if (posicaoComputador >= limiteLinhaChegada)
                return "Computador Venceu";
        }

        return "";
    }

    static int SortearNumero()
    {
        Random geradorDeNumeros = new Random();

        resultado = geradorDeNumeros.Next(1, 7);

        return resultado;
    }

    public static void Resetar()
    {
        posicaoJogador = 0;
        posicaoComputador = 0;
        resultado = 0;
        quantidadeRodadasJogador = 1;
        quantidadeRodadasComputador = 1;
    }
}
