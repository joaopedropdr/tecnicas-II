
List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa() { Nome = "João", Idade = 25 },
    new Pessoa() { Nome = "Maria", Idade = 30 },
    new Pessoa() { Nome = "Pedro", Idade = 17 },
    new Pessoa() { Nome = "Ana", Idade = 15 },
    new Pessoa() { Nome = "Paula", Idade = 28 }
};
var pessoasOrdenadas = pessoas.OrderBy(p => p.Nome).ToList();
var maiorIdade = pessoas.Where(p => p.Idade >= 18).ToList();

Console.WriteLine("Ordem alfabetica");
foreach (var item in pessoasOrdenadas)
{
    Console.WriteLine(item.Nome);
}
Console.WriteLine("Maiores de idade");
foreach (var item in maiorIdade)
{
    Console.WriteLine(item.Nome);
}
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

}
