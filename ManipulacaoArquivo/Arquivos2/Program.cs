var pessoa = new Pessoa { Nome = "Maria", Idade = 23};

// Serialização Transforma objetos em arquivos json, xml, etc.
string json = System.Text.Json.JsonSerializer.Serialize(pessoa);
Console.WriteLine(json);
// Desserilização. Transforma arquivos json, xml, etc em objetos.
var jsonString = "{\"Nome\":\"João\", \"idade\":25 }";
Pessoa pessoaDados = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(jsonString);
Console.WriteLine(pessoaDados.Nome);
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