namespace ScreenSound.Models;

internal class Podcast
{
    List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios =>
        episodios.Count;

    public void AdicionarEpisódio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do podcast: {Nome}");
        Console.WriteLine($"Apresentado por: {Host}");

        Console.WriteLine($"\nLista de episódios no podcast:\n");

        foreach (var episodio in episodios.OrderBy(episodio => episodio.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"Esse podcast tem {TotalEpisodios} episódios.");
    }

}