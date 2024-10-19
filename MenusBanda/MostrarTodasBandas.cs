using ScreenSound.Models;
using ScreenSound.TituloGeral;

namespace ScreenSound.MenusBanda;

internal class MostrarTodasBandas : MenuBanda
{
    public override void Executar(Dictionary<string, Banda> bandas)
    {
        try
        {
            base.Executar(bandas);
            Console.WriteLine("Lista de Bandas registradas: \n");

            Console.WriteLine($"Nome: {string.Join("\nNome: ", bandas.Keys)}");

            Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"\nOcorreu um erro: {e.Message}");

            Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
