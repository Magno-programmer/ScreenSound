

namespace ScreenSound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if(nota >=0 && nota <= 10)
        {
            Nota = nota;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int notaInteira = int.Parse(texto);
        return new Avaliacao(notaInteira);
    }

}
