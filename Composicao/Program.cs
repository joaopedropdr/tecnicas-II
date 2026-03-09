// Relacionamento Composição (1:n)
// composição do lado de Pessoa(bilateral) pessoa->celular

Pessoa pessoa1 = new("João Pedro", 14, "998091920");
pessoa1.SetCelular(14, "998190340");

Console.WriteLine("Composição do lado de pessoa pessoa->celular");
Console.WriteLine($"Nome: {pessoa1.Nome}");
foreach (var dado in pessoa1.Celulares)
{
    Console.WriteLine($"({dado.Ddd}) {dado.Numero}");
}

// Composição do lado de celular celular->pessoa
// PEssoa2 foi declarada 
Pessoa pessoa2 = new Pessoa("Altair");
Celular cel = new(16, "666666666", pessoa2);
Console.WriteLine($"Composição do lado da parte celular->pessoa");
Console.WriteLine($"Nome: {cel.PessoaCelular.Nome}\nTelefone: ({cel.Ddd}) {cel.Numero}");
public class Pessoa 
{
    public Pessoa(string nome, int ddd, string numero)
    {
        Nome = nome;
        Celulares.Add(new Celular(ddd, numero));
    }
    public Pessoa(string nome)
    {
        Nome= nome;
    }

    public void SetCelular(int ddd, string numero)
    {
        Celulares.Add(new Celular(ddd, numero));  
    }

    public string? Nome { get; set; }
    public List<Celular> Celulares = new();
    
}

public class Celular
{
    public Celular(int ddd, string numero)
    {
        Ddd = ddd;
        Numero = numero;
    }

    public Celular(int ddd, string numero, Pessoa pessoa)
    {
        Ddd = ddd;
        Numero = numero;
        PessoaCelular = pessoa;

    }

    public int Ddd { get; set; }
    public string? Numero { get; set; }
    public Pessoa PessoaCelular { get; set; }
}
