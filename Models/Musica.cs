namespace ScreenSound.Models;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} é referênte ao artista {Artista}";

    public void ExibirInformacoesDoArtista()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Você está usando o Plano Plus");

        }else
        {
            Console.WriteLine("Habilite o Plano Plus");
        }
        


    }

}