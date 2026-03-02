// Array normal. De um unico tipo e voce define o numero de valores do array.
using System.Runtime.InteropServices.Marshalling;

int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Podemos declarar um array e depois atribuir os valores
int[] valores;
// Ele so fica na memoria quando voce atribui algum valor a ele.
valores = [10, 20];
string[] nomes = new string[5] { "MAria", "João", "Luis", "Julia", "Yasmim" };
// Classe Array
Array.Reverse(numeros);
Array.Sort(nomes);
int indice = Array.BinarySearch(nomes, "Julia");
Console.WriteLine($"Indice do nome Julia {indice}");
// mostrar com foreach
foreach(var dado in nomes)
{

    Console.WriteLine(dado);
}

// Mostrar com for
for(int i=0; i < 2; i++)
{
    Console.WriteLine(valores[i]);
}
// Matriz
// Define o numero de linhas e colunas
// 3 linhas 2 colunas
int[,] matriz = new int[3, 2] {{1, 2}, {3, 4}, { 5, 6 } };
for(int i =0; i< matriz.GetLength(0); i++)
{
    for(int j=0; j< matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j]);
    }
}

// Usando foreach 
foreach(var dado in matriz)
{
    Console.WriteLine(dado);
}