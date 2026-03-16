using System.Reflection;

Console.WriteLine("Café da manhã sincrono");
cafeDaManhaAsync();
Console.WriteLine("Fim do Café da manhã");

static async void cafeDaManhaAsync()
{
    Console.WriteLine("Preparar o café");
    var TarefaCafe = PrepararCafeAsync();
    Console.WriteLine("\n Preparar o pão");
    var TarefaPao = PrepararPaoAsync();
    var cafe = await (TarefaCafe);
    var pao = await (TarefaPao);
    ServirCafeAsync(cafe, pao);
}

static void ServirCafeAsync(Cafe cafe, Pao pao)
{
    Console.WriteLine("\n Servindo café da manhã");
    Thread.Sleep(2000);
    Console.WriteLine("\n Café da manhã servido.");
}

static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("\n Partir o pão");
    await Task.Delay(2000);
    Console.WriteLine("\n Passar manteiga");
    await Task.Delay(2000);
    return new Pao();
}

static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("\n Ferver a água");
    await Task.Delay(2000);
    Console.WriteLine("\n Coar o café");
    await Task.Delay(2000);
    return new Cafe();
}

internal class Cafe
{

}
internal class Pao
{

}