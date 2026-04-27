using System.Text.Json;

var caminho = "pessoas.json";
List<Pessoa> listaPessoas = new List<Pessoa> 
{
     new Pessoa { Nome = "Maria", Idade = 23 },
     new Pessoa { Nome = "João", Idade = 25 },
     new Pessoa { Nome = "Lucas", Idade = 17 },
     new Pessoa { Nome = "Ana", Idade = 43 },
    
};
// Serialização em arquivo. 
if(!File.Exists(caminho))
{
    string jsonString = JsonSerializer.Serialize(listaPessoas, new JsonSerializerOptions { WriteIndented = true});
    File.WriteAllText(caminho, jsonString );
    Console.WriteLine("Arquivo json gravado");
            
}
// Desserilização
if(File.Exists(caminho))
{
    string conteudo = File.ReadAllText(caminho);
    List<Pessoa> listaConteudo = JsonSerializer.Deserialize<List<Pessoa>>(conteudo);
    Console.WriteLine("Lista de Pessoas");
    foreach(var p in listaConteudo)
    {
        Console.WriteLine($"Nome: {p.Nome} - Idade: {p.Idade}");
    }
            
}

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    // Construtor sem parametros para fazer a desserilização
    public Pessoa()
    {

    }
}