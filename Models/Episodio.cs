namespace ScreenSound.Models;

internal class Episodio
{
    private List<string> convidados = new();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo =>
        $"{Ordem}. Episódio {Titulo}, Duração: {Duracao} minutos - convidados: {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}