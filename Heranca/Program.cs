
// Usando
Aluno aluno1 = new("João Pedro", "444.555.666.77", "0102392511022");
Console.WriteLine($"NOME: {aluno1.Nome}\nCPF: {aluno1.Cpf}\nRA: {aluno1.Ra}");

Console.WriteLine("Digite o nome do professor");
var nomeProf = Console.ReadLine();
Console.WriteLine("Digite o CPF do professor");
var cpfProf = Console.ReadLine();
Console.WriteLine("Digite a titulação do professor");
var titulacaoProf = Console.ReadLine();

Professor prof1 = new(nomeProf, cpfProf, titulacaoProf);
Professor.Exibir(prof1);


// Declarando 
public class Pessoa
{
    public Pessoa(string? nome, string? cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
}

// O : é a herança 
// Aluno esta herdando Pessoa
public class Aluno : Pessoa
{
    // base é usado para referenciar os parametros da classe pai
    public Aluno(string? nome, string? cpf, string? ra):base(nome, cpf)
    {
        Ra = ra;
    }
    public string? Ra { get; set; }
}

public class Professor:Pessoa
{
    public Professor(string? nome, string? cpf, string? titulacao) : base(nome, cpf)
    {
        Titulacao = titulacao;
    }
    // Métodos static não pertencem ao objeto e sim a classe. Para invocar ele precisa passar a classe depois o metodo ( Professor.Exibir).
    public static void Exibir (Professor prof) => Console.WriteLine($"NOME: {prof.Nome}\nCPF: {prof.Cpf}\nTITULAÇÃO: {prof.Titulacao}");
    

    public string? Titulacao { get; set; }

}



