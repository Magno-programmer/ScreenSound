using ScreenSound.Interfaces;

namespace ScreenSound.Models;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new();
    private List<Avaliacao> notas = new();

    public string Nome { get; set; }
    public List<Musica> Musicas => musicas;
    public int DuracaoTotal => 
        musicas.Sum(m => m.Duracao);

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(avaliacao => avaliacao.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void Avaliar(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}: \n");

        foreach(var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }

        Console.WriteLine($"\nEste álbum tem {DuracaoTotal} segundos.");
    }
}