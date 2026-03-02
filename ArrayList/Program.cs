using System.Collections;
// ArrayList: UM array dinamico. Não precisa especificar o tamanho nem o tipo
ArrayList lista = new ArrayList(5);
// Adiciona valores ao array
lista.Add("Maria");
lista.Add(18);
lista.Add(1.65);
lista.Add(true);
lista.Add(null);
// Insere um novo valor a posição 3
lista.Insert(3, 65);

int[] array = { 1, 2, 3 };
// Adiciona uma coleção no final de um ArrayList
lista.AddRange(array);
// Adiciona uma coleção no indice passado
lista.InsertRange(0, array);

// Remove um elemento especifico do arrayList
lista.Remove("Maria");
// Remove o elemento do indice passado
lista.RemoveAt(0);
// Remove a partir de um indice e remove uma quantidade especifica de elementos
// Começa no indice 2 e remove 4 elementos
lista.RemoveRange(2, 4);
foreach (var dado in lista)
{
    Console.WriteLine(dado);
}

ArrayList lista2 = new() { "Maria", "Paulo", "Ana"};
lista2.Sort();
var res1 = lista2.Contains("Maria");
foreach (var dado in lista2)
{
    Console.WriteLine(dado);
}

if(res1)
{
    Console.WriteLine("Contém");
} else
{
    Console.WriteLine("Não contém");
}

lista2.Clear();
foreach (var dado in lista2)
{
    Console.WriteLine(dado);
}
