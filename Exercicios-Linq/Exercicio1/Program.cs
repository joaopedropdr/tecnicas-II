
public static class List
{
    public static int SomaValoresImpares(this List<int> lista)
    {
        return lista.Where(x => x % 2 != 0).Sum();
    }
}

partial class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>() { 5, 12, 8, 20, 3, 15, 7 };

        int x = numeros.SomaValoresImpares();

        Console.WriteLine($"Soma dos numeros impares: {x}");
    }
}