using ScreenSound.Interfaces;

namespace ScreenSound.Models;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();

    public string? Nome { get; set; }
    public double Media
    {
        get 
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(avaliacao => avaliacao.Nota); 
        }
    }

    public string? Resumo { get; set; }

    public List<Album> Albuns => albuns;

    public void Avaliar(Avaliacao nota)
    {
        notas.Add(nota);
    }

    //Sobre nome das bandas

    public string ExibirListaDeBandas(Dictionary<string, List<int>> bandas)
    {

        foreach (var nome in bandas)
        {
            return $"Nome: {nome.Key}.";
        }

        return "Não há bandas Registradas.";
    }

    //Sobre album
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public string ExibirAlbuns()
    {
        foreach (var album in albuns)
        {
            return $"Nome: {album.Nome}. " +
                $"\nDuração: {album.DuracaoTotal} segundos." +
                $"\nQuantidade de músicas: {album.Musicas.Count}" +
                $"\nMédia: {album.Media}";
        }

        return "Não há albuns registrados";
    }
}