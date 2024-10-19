using ScreenSound.Models;
using ScreenSound.TituloGeral;

namespace ScreenSound.MenusBanda;

internal class MediaDaAvaliacaoBanda : MenuBanda
{
    public override void Executar(Dictionary<string, Banda> bandas)
    {
        base.Executar(bandas);

        Subtitulo("Média da Banda");

        try
        {
            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!; ;
            if (bandas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandas[nomeDaBanda];

                Console.WriteLine($"Média da banda {nomeDaBanda} é: {banda.Media}");

                Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não está registrada.");

                Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
            }

        }
        catch (Exception e)
        {

            Console.WriteLine($"\nOcorreu um erro: {e.Message}");

            Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
