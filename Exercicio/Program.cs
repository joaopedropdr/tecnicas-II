// Exercicio incompleto!! Arrumar depois.
Fabrica Fabrica = new Fabrica("Fabrica de Automóveis");
Fabrica.AdicionarMaquina(new Maquina("Modelo X", "8 horas", Guid.NewGuid(), "Montadora de Chassis", DateTime.Now));
Fabrica.AdicionarMaquina(new Maquina("Modelo Y", "10 horas", Guid.NewGuid(), "Montadora de Motores", DateTime.Now));
Fabrica.ListasMaquinas();

Operador operador1 = new Operador("João");

operador1.OperarMaquinaAsync(Fabrica, "Modelo X").Wait();


public class Fabrica
{
    public Fabrica(string nome)
    {
        Nome = nome;   
    }

    public void AdicionarMaquina(Maquina maquina)
    {
        Maquinas.Add(maquina);
    }

    public void ListasMaquinas()
    {
        foreach (var maquina in Maquinas)
        {
            Console.WriteLine($"Maquina: {maquina.Nome}, Modelo: {maquina.Modelo}, Data de Fabricação: {maquina.DataFabricacao}, Numero de Serie: {maquina.NumeroSerie}");
        }
    }

    public Maquina? BuscarMaquinaPorModelo(string modelo)
    {
        foreach (var maquina in Maquinas)
        {
            if (maquina.Modelo == modelo)
            {
                Maquina? modeloEncontrado = new Maquina(maquina.Modelo, maquina.HoraOperacao, maquina.NumeroSerie, maquina.Nome, maquina.DataFabricacao);
                return modeloEncontrado;
            } 
        }
        return null;
    }
    public string? Nome { get; set; }
    public ICollection<Maquina> Maquinas = new List<Maquina>();
}

public class Operador 
{
    public Operador(string nome)
    {
        Nome = nome;
    }

    public async Task<Operador> OperarMaquinaAsync(Fabrica fabrica, string Modelo) 
    {
        Console.WriteLine($"{this.Nome} está tentanto operar a maquina modelo {MaquinaOperador.Modelo}");
        await Task.Delay(2000);
        var maquinaEncontrada = fabrica.BuscarMaquinaPorModelo(Modelo);
        if(maquinaEncontrada == null)
        {
            Console.WriteLine($"Maquina do Modelo: {MaquinaOperador.Modelo} não foi encontrada na fabrica {fabrica.Nome}");

        }

        Console.WriteLine($"{this.Nome} agora está operando a maquina do modelo {MaquinaOperador.Modelo}");
        await Task.Delay(3000);
    }
    public string? Nome { get; set; }
    public Maquina? MaquinaOperador { get; set; }
}


public class Equipamento 
{
    public Equipamento(string nome, DateTime dataFabricacao)
    {
        Nome = nome;
        DataFabricacao = dataFabricacao;
    }
    public string? Nome { get; set; }
    public DateTime DataFabricacao { get; set; }
}


public class Maquina: Equipamento
{
    public Maquina(string? modelo, string? horaOperacao, Guid numeroSerie, string? observacao, string nome, DateTime dataFabricacao):base(nome, dataFabricacao)
    {
        Modelo = modelo;
        HoraOperacao = horaOperacao;
        NumeroSerie = numeroSerie;
        Observacao = observacao;
    }

    public Maquina(string? modelo, string? horaOperacao, Guid numeroSerie, string nome, DateTime dataFabricacao):base(nome, dataFabricacao) 
    {
        Modelo = modelo;
        HoraOperacao = horaOperacao;
        NumeroSerie = numeroSerie;
    }

    public string? Modelo { get; set; }
    public string? HoraOperacao { get; set; }
    public readonly Guid NumeroSerie;
    public string? Observacao 
    { 
        set {}
    }
    public ICollection<Operador> OperadorMaquina = new List<Operador>();
    

}
