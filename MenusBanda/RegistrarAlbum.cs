using ScreenSound.Models;
using ScreenSound.TituloGeral;

namespace ScreenSound.MenusBanda;

internal class RegistrarAlbum : MenuBanda
{
    public override void Executar(Dictionary<string, Banda> bandas)
    {
        base.Executar(bandas);
        Subtitulo("Registro de Album");
        try
        {
            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandas[nomeDaBanda];
                Console.Write("Digite o nome do album: ");
                string nomeDoAlbum = Console.ReadLine()!;

                if(!banda.Albuns.Any(album => album.Nome.Equals(nomeDoAlbum)))
                {
                    Album album = new();
                    album.Nome = nomeDoAlbum;
                    banda.AdicionarAlbum(album);

                }
                else
                {
                    Console.WriteLine("O album escolhido já foi registrado.");

                    Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine($"O album {nomeDoAlbum} da banda {nomeDaBanda} foi registrado com sucesso");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("A banda escolhida ainda não foi registrada.");

                Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"\nBanda não registrada, ocorreu um erro: {e.Message}");

            Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
