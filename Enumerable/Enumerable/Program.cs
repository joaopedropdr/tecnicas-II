// IEnumerable não permite alteração na coleção
List<string> Nomes = new List<string> { "Luisa", "Luis", "João"};
string[] array = { "Clara", "Lucas" };

IEnumerable<string> Inomes = new List<string> { "Carlos" }; 
ExibirNomes(Nomes);
ExibirNomes(array);
ExibirNomes(Inomes);


void ExibirNomes(IEnumerable<string> colecoes)
{
    foreach(var dado in colecoes)
    {
        Console.WriteLine(dado);
    }
}