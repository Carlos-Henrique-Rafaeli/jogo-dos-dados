namespace JogoDosDados.ConsoleApp;

public class Dado
{
    public int Sortear()
    {
        Random geradorDeNumeros = new Random();

        int resultado = geradorDeNumeros.Next(1, 7);

        return resultado;
    }
}
