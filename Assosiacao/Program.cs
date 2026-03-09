Fornecedor for1 = new("empresa 1", "333.44411/0001-23");
Produto prod1 = new("Produto 1", 10.50);
Categoria cat1 = new("Categoria 1");



// Fazendo o relacionamento entre as classes 
// Assosiação bilateral produto->fornecedor 
prod1.Fornecedores.Add(for1);
// Agregação unilateral produto->categoria
prod1.CategoriaProduto = cat1;

Fornecedor for2 = new("empresa 2", "555.44411/0001-44");
Produto prod2 = new("Produto 2", 10.50);
Produto prod3 = new("Produto 3", 10.50);

prod2.Fornecedores.Add(for2);
prod3.Fornecedores.Add(for2);


public class Produto
{
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    // Relacionamento das classes
    // CategoriaProdutos Agregação (1:n)
    public Categoria? CategoriaProduto { get; set; }
    // Fornecedor Assosiação (n:N)
    public List<Fornecedor> Fornecedores = new();
}

public class Categoria
{
    public Categoria(string descritivo)
    {
        Descritivo = descritivo;
    }

    public string? Descritivo { get; set; }


}
public class Fornecedor
{
    public Fornecedor(string razaoSocial, string cnpj)
    {
        RazaoSocial = razaoSocial;
        Cnpj = cnpj;
    }
    public string? RazaoSocial { get; set; }
    public string? Cnpj { get; set; }
    public List<Produto> Produtos = new();
}