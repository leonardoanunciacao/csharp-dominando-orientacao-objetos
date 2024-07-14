using ScreenSound.Modelos;

namespace ScreenSound.Menus;
internal class OpcaoSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Fechando programa... ;)");
    }
}