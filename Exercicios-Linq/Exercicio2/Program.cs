using System;
using System.Collections.Generic;
using System.Linq; 

public static class List
{
    public static int MaiorValor(this List<int> lista)
    {
        return lista.Max();
    }
}

partial class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>() { 5, 12, 8, 20, 3, 15, 7 };

        int x = numeros.MaiorValor();

        Console.WriteLine($"Maior valor encontrado: {x}");
    }
}