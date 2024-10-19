using ScreenSound.MenusBanda;
using ScreenSound.Models;
using ScreenSound.TituloGeral;

try
{

    Dictionary<string, Banda> bandas = new();
    Dictionary<int, MenuBanda> menusBanda = new();

    //Adicionando as opções no dicionario
    menusBanda.Add(1, new RegistrarBanda());
    menusBanda.Add(2, new RegistrarAlbum());
    menusBanda.Add(3, new MostrarTodasBandas());
    menusBanda.Add(4, new AvaliarBanda());
    menusBanda.Add(5, new ExibirDetalhesDaBanda());

    void ExibirOpcoes()
    {
        try
        {
            TituloGeral.Titulo();
            Console.WriteLine("\nOpção 1 - Registrar banda");
            Console.WriteLine("Opção 2 - Registrar album");
            Console.WriteLine("Opção 3 - Mostrar todas as bandas");
            Console.WriteLine("Opção 4 - Avaliar banda");
            Console.WriteLine("Opção 5 - Exibir detalhes da banda");
            Console.WriteLine("Opção 0 - Sair");

            Console.Write("\n\nEscolha uma das opções: ");

            int opcaoEscolhida = int.Parse(Console.ReadLine()!);

            if (menusBanda.ContainsKey(opcaoEscolhida) || opcaoEscolhida == 0)
            {
                if(opcaoEscolhida != 0)
                {
                    MenuBanda menu = menusBanda[opcaoEscolhida];
                    menu.Executar(bandas);
                    ExibirOpcoes();
                }
                else
                {
                    Console.WriteLine("Até logo!");
                }
            }

        }
        catch(Exception e)
        {
            Console.Clear();
            Console.WriteLine($"\nOcorreu um erro: {e.Message}\n");
            ExibirOpcoes();
        }

    }

    ExibirOpcoes();
    Console.ReadKey();
}
catch (Exception e)
{
    Console.Clear();
    Console.WriteLine($"\nOcorreu um erro: {e.Message}\n");
    Console.ReadKey();

}