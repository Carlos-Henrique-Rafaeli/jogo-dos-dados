namespace JogoDosDados.ConsoleApp;

public class Jogador
{
    public int posicao = 0;
    public string nome;

    private int[] casasAvanco = [5, 10, 15, 25];
    private int[] casasRecuo = [7, 13, 20];

    public Jogador(string nome)
    {
        this.nome = nome;
    }

    public void Avancar(int resultado)
    {
        posicao += resultado;
    }

    public void AvancarExpecial()
    {
        posicao += 3;
    }

    public void RecuarExpecial()
    {
        posicao -= 2;
    }

    public bool EstaNaPosicaoAvancarExpecial()
    {
        return casasAvanco.Contains(posicao);
    }

    public bool EstaNaPosicaoRecuarExpecial()
    {
        return casasRecuo.Contains(posicao);
    }

    public bool UltrapassouLinhaDeChegada(int linhaChegada)
    {
        return posicao >= linhaChegada;
    }

}
