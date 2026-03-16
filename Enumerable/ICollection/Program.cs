ICollection<string> nomes = new List<string> { "Lucas", "Altair", "Diego"};
nomes.Add("Lukas moura rayquaza");

string[] array = new string[nomes.Count];
// CopyTo vai copiar o array nomes no novo array passado no parametro (array)
nomes.CopyTo(array, 0);

foreach(var nome in nomes)
{
    Console.WriteLine(nome);
}
foreach(var nome in array)
{
    Console.WriteLine(nome);
}