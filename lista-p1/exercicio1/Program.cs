using exercicio1;

var multa1 = new Multa() { Placa = "ABC1234", TipoInfracao = "Excesso de velocidade", Valor = 501.0, Data = DateTime.Now };
var multa2 = new Multa() { Placa = "XYZ5678", TipoInfracao = "Estacionamento proibido", Valor = 200.0, Data = DateTime.Now };

CentralDeMultas central = new CentralDeMultas();

// Metodo para lidar com multas graves 
static void MultaGraveHandler(Multa m)
{
    if (m.Valor > 500)
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("!!! MULTA GRAVE DETECTADA !!!");
        Console.WriteLine($" Placa: {m.Placa} Valor: {m.Valor}");
        Console.WriteLine("-------------------------------");
    }
}
central.MultaRegistrada += MultaGraveHandler;

central.registrarMulta(multa1);
central.registrarMulta(multa2);

Console.WriteLine("------------------");
central.SalvarMultaJson();
Console.WriteLine("------------------");
central.GetMultaJson();
// Consultas LINQ
Console.WriteLine("------------------");
List<Multa> multas = central.getMultas();
var multasAcimaDe300 = multas.Where(m => m.Valor > 300).ToList();
foreach (var multa in multasAcimaDe300)
{
    Console.WriteLine($"Multa acima de 300: {multa.Placa} - {multa.TipoInfracao} - {multa.Valor} - {multa.Data}");
}