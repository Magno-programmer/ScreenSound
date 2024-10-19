using ScreenSound.Models;
using ScreenSound.TituloGeral;

namespace ScreenSound.MenusBanda; 

internal class ExibirDetalhesDaBanda : MenuBanda
{
    public override void Executar(Dictionary<string, Banda> bandas)
    {
        try
        {
            base.Executar(bandas);
            Subtitulo("Resumo da Banda");

            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandas[nomeDaBanda];
                Console.WriteLine($"\nBanda: {nomeDaBanda}");
                Console.WriteLine($"Média: {banda.Media}");
                Console.WriteLine($"Resumo da Banda: {banda.Resumo}\n");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"\nDona dos albuns: \n");
                Console.WriteLine(banda.ExibirAlbuns());



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
        catch (System.Exception e)
        {
            Console.WriteLine($"\nOcorreu um erro: {e.Message}");

            Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
