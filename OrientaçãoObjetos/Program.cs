// No c# as instancias vem primeiro que as declarações, por isso a separação de usando e declarando.
// Usando 

// Prod1
// Duas formas de instanciar um objeto
//Produto prod1 = new Produto();
using OrientaçãoObjetos;

Produto prod1 = new();
prod1.Nome = "Caderno";
prod1.Preco = 10.5;

Console.WriteLine("Nome: " + prod1.Nome);
Console.WriteLine($"Preço: {prod1.Preco}");

// Prod2
Produto prod2 = new("Caneta", 7.90);
Console.WriteLine("Nome: " + prod2.Nome);
Console.WriteLine($"Preço: {prod2.Preco}");

// Objeto de produto2
Produto2 prod3 = new("Borracha", 10.55, 100);
prod3.Exibir();

Produto2 prod4 = new("Lapís", 4.45, 90);
prod4.Exibir();

Console.ReadKey();
// Declarando
public class Produto
{
    // Construtor padrao, usado para não precisar passar parametros na instancia do objeto
    public Produto(){}

    // Método construtor 
    public Produto(string nome, double Preco)
    {
        Nome = nome;
        // Se o nome do parametro do construtor for igual ao metodo é necessario usar o this
        this.Preco = Preco;
    }
    // O ? faz com que a string possa começar como nula
    public string? Nome { get; set; }
    public double Preco { get; set; }
}


