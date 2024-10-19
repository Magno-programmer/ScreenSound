using ScreenSound.Models;

namespace ScreenSound.TituloGeral;

internal class MenuBanda
{
    public void Subtitulo(string titulo)
    {
        int quantidadeDeCaracter = titulo.Length;
        string asteristico = new string('*', quantidadeDeCaracter);

        Console.WriteLine(asteristico);
        Console.WriteLine(titulo);
        Console.WriteLine(asteristico);

    }

    public virtual void Executar(Dictionary<string, Banda> bandas) { Console.Clear(); }
}
