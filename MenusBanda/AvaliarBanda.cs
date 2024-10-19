using ScreenSound.Models;
using ScreenSound.TituloGeral;

namespace ScreenSound.MenusBanda;

internal class AvaliarBanda : MenuBanda
{
    public override void Executar(Dictionary<string, Banda> bandas)
    {
        base.Executar(bandas);
        Subtitulo("Avaliação de Banda");

        try
        {
            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandas[nomeDaBanda];
                Console.Write($"\nDigite uma nota para a banda {nomeDaBanda}: ");
                Avaliacao notaInteira = Avaliacao.Parse(Console.ReadLine()!);

                banda.Avaliar(notaInteira);

                Console.WriteLine($"A banda {nomeDaBanda} recebeu a nota {notaInteira.Nota}");

                Thread.Sleep(3000);
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

            Console.Write($"\nOcorreu um erro: {e.Message}");

            Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
