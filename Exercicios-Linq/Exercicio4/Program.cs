

List<Clientes> clientelista = new List<Clientes>
            {
                new Clientes { Nome = "Ana Silva", Cpf = "111.111.111-11" },
                new Clientes { Nome = "Bruno Souza", Cpf = "222.222.222-22" },
                new Clientes { Nome = "Carla Dias", Cpf = "333.333.333-33" },
                new Clientes { Nome = "Diego Alves", Cpf = "444.444.444-44" },
                new Clientes { Nome = "Elisa Mello", Cpf = "555.555.555-55" }
            };
List<Produtos> produtosLista = new List<Produtos>
    {
                new Produtos { Nome = "Notebook", Preco = 4500.00 },
                new Produtos { Nome = "Mouse", Preco = 150.00 },
                new Produtos { Nome = "Teclado", Preco = 250.00 },
                new Produtos { Nome = "Monitor", Preco = 1200.00 },
                new Produtos { Nome = "Cadeira", Preco = 800.00 }
    };

List<Pedidos> pedidos = new List<Pedidos>
        {
            new Pedidos { Quantidade = 1, DataPedido = DateTime.Now, Produto = produtosLista[0], Cliente = clientelista[0] },
            new Pedidos { Quantidade = 2, DataPedido = DateTime.Now, Produto = produtosLista[1], Cliente = clientelista[0] }, 
            new Pedidos { Quantidade = 1, DataPedido = DateTime.Now, Produto = produtosLista[2], Cliente = clientelista[1] },
            new Pedidos { Quantidade = 1, DataPedido = DateTime.Now, Produto = produtosLista[3], Cliente = clientelista[2] },
            new Pedidos { Quantidade = 1, DataPedido = DateTime.Now, Produto = produtosLista[4], Cliente = clientelista[3] }
        };

// a) Mostrar todos os pedidos agrupados pelo cliente
Console.WriteLine("---------A---------");
var pedidosAgrupados = pedidos.GroupBy(p => p.Cliente?.Nome).ToList();
foreach (var grupo in pedidosAgrupados)
{
    Console.WriteLine($"Cliente: {grupo.Key}");
    foreach (var pedido in grupo)
    {
        Console.WriteLine($"  Produto: {pedido.Produto?.Nome}, Quantidade: {pedido.Quantidade}, Data: {pedido.DataPedido}");
    }
}

// b-) Nomes dos clientes que fizeram pedidos acima de 500 reais
Console.WriteLine("---------B---------");
var pedidosAcima500 = pedidos.Where(p => p.Produto?.Preco > 500);
foreach (var cli in pedidosAcima500)
{
    Console.WriteLine($"Cliente: {cli.Cliente?.Nome}");
}


// c-) Calcular o valor total de pedidos por cliente
Console.WriteLine("---------C---------");
var totalPedidosCiente = pedidos.GroupBy(p => p.Cliente?.Nome);
foreach (var grupo in totalPedidosCiente)
{
    Console.WriteLine($"Cliente: {grupo.Key}");

    double total = grupo.Sum(p => p.Produto?.Preco * p.Quantidade ?? 0);
    Console.WriteLine($"  Total gasto do cliente: {total}"); 
}

public class Clientes
{
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
}

public class Produtos
{
    public string? Nome { get; set; }
    public double Preco { get; set; }
}

public class Pedidos
{
    public int Quantidade { get; set; }
    public DateTime DataPedido { get; set; }

    public Produtos? Produto { get; set; }
    public Clientes? Cliente { get; set; }

}

