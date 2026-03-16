Console.WriteLine("Cafe da manha sincrono");

CafeDaManha();
Console.WriteLine("Fim do cafe da manha");

static void CafeDaManha()
{
    Console.WriteLine("Preparar cafe");
    var cafe = PrepararCafe();
    Console.WriteLine("\nPreparar o pão");
    var pao = PrepararPao();
    ServirCafe(cafe, pao);

}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServir cafe");
    Thread.Sleep(2000);
    Console.WriteLine("\nCafe servido");
}

static Pao PrepararPao()
{
    Console.WriteLine("\nPreparar Pao");
    Thread.Sleep(2000);
    Console.WriteLine("\nPassar manteiga");
    Thread.Sleep(2000);
    return new Pao();
}
static Cafe PrepararCafe()
{
    Console.WriteLine("\nFerver Agua");
    Thread.Sleep(2000);
    Console.WriteLine("\nCOar cafe");
    Thread.Sleep(2000);
    return new Cafe();
}

internal class Pao
{

} 
internal class Cafe
{

} 