
using System.Reflection;

Fabrica fabrica1 = new Fabrica("Anderson LTDA", "Modelo1", "1000", "mAQUINA Nova", "maquina monstra 01", new DateTime(25, 12, 10));
fabrica1.AdicionarMaquina("Modelo2", "1500", "Maquina de cortar", "maquina 02", new DateTime(24, 12, 12));
fabrica1.AdicionarMaquina("Modelo3", "2500", "Prensa", "maquina 03", new DateTime(26, 06, 30));

fabrica1.ListasMaquinas();

Maquina maquina1 = new("Modelo04", "300", "MAquina das braba", "machinnn", new DateTime(26, 07, 17));
Operador operador1 = new("Lucas", maquina1);

await operador1.OperarMaquinaAsync(fabrica1, "Modelo2");

// Relacionamento Fabrica e Maquina. Composição unilateral, as maquinas vão para fabrica como um objeto e fabrica não vai para maquina. 1:N
public class Fabrica
{
    public Fabrica(string nomeFabrica, string modelo, string horaOperacao, string? observacao, string nome, DateTime dataFabricacao)
    {
        Nome = nomeFabrica;
        MaquinaFabrica.Add(new Maquina(modelo, horaOperacao, observacao, nome, dataFabricacao));
    }

    public string? Nome { get; set; }
    public ICollection<Maquina> MaquinaFabrica { get; set; } = new List<Maquina>();
    // Para instanciar uma nova maquina, voce não pode receber um objeto maquina ja criado.
    
    public void AdicionarMaquina(string modelo, string horaOperacao, string? observacao, string nome, DateTime dataFabricacao)
    {
        MaquinaFabrica.Add(new Maquina(modelo, horaOperacao, observacao, nome, dataFabricacao)); ;
    }

    public void ListasMaquinas()
    {
        foreach (var maquina in MaquinaFabrica)
        {
            Console.WriteLine($"Modelo: {maquina.Modelo}\nHora de Operação: {maquina.HoraOperacao}\nNumero de Serie: {maquina.NumeroSerie}\n Nome do equipamento: {maquina.Nome}\n Data de fabricação: {maquina.DataFabricacao}");
        }
    }

    public Maquina BuscarMaquinaPorModelo(string modelo)
    {
        // Duas maneiras de se encontrar a maquina. Usando um foreach
        //foreach (var maquina in MaquinaFabrica)
        //{
        //    if(maquina.Modelo == modelo)
        //    {
        //        return maquina;
        //    }
        //}
        //return null;


        // Usando o find
        var list = MaquinaFabrica.ToList();
        var maquina = list.Find(m =>  m.Modelo == modelo);
        return maquina;
    }
}

// Relacionamento Assosiação Unilateral. Maquina vai para operador e operador não vai para maquina
public class Operador
{
    public Operador(string nome, Maquina maquina)
    {
        Nome = nome;
        MaquinaOperador = maquina;
    }
    public async Task OperarMaquinaAsync(Fabrica fabrica, string modelo)
    {
        Console.WriteLine($"{Nome} está tentando operar a maquina {modelo}");
        await Task.Delay(3000);
        var maquina = fabrica.BuscarMaquinaPorModelo(modelo);
        if( maquina == null )
        {
            Console.WriteLine($"Maquina modelo {modelo} não encontrada na fabrica {fabrica.Nome}");

        } else
        {
            Console.WriteLine($" {Nome} está operando a maquina modelo {maquina.Modelo}");
            await Task.Delay(3000);

        }
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

// Herança de maquina e equipamentos. Maquina herda Equipamentos
// Maquica 
public class Maquina : Equipamento
{
    public Maquina(string modelo, string horaOperacao, string? observacao, string nome, DateTime dataFabricacao) : base(nome, dataFabricacao)
    {
        Modelo = modelo;
        HoraOperacao = horaOperacao;
        Observacao = observacao;
    }


    public string? Modelo { get; set; }
    public string? HoraOperacao { get; set; }
    // propriedade readOnly
    private Guid numeroSerie = Guid.NewGuid();
    public Guid NumeroSerie { get { return numeroSerie; } }
    // writeOnly
    private string? observacao; 
    public string? Observacao
    {
        set { observacao = value; }
    }


}
