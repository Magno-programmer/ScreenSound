using ScreenSound.Models;
using ScreenSound.TituloGeral;
using ScreenSound.APIConections;
using OpenAI_API.Moderation;

namespace ScreenSound.MenusBanda;

internal class RegistrarBanda : MenuBanda
{
    public override void Executar(Dictionary<string, Banda> bandas)
    {
        base.Executar(bandas);
        Subtitulo("Registro de Banda");
        try
        {
            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;
            string resumo;

            if (!bandas.ContainsKey(nomeDaBanda))
            {
                bandas.Add(nomeDaBanda, new());

                try
                {
                    resumo = APIConection.Conectar(nomeDaBanda);
                }
                catch
                {
                    resumo = "Não foi possível coletar o resumo dessa banda";
                }

                bandas[nomeDaBanda].Resumo = resumo;

                Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso");

                Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("A banda escolhida já foi registrada.");

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
