// List: Igual um arrayList mas de apenas um tipo
var lista = new List<string>();
lista.Add("Laranja");

List<int> lista2 = new();

var lista3 = new List<string>() { "João", "Luis", "Maria" };


List<Carro> carros = new();
Carro carro1 = new Carro("Citrone", "Air Cross", 2015);
carros.Add(carro1);
carros.Add(new Carro("Volwksvagem", "Jetta GLI", 2025));
foreach (var item in carros)
{
    Console.WriteLine(item);
}
public class Carro 
{
    public Carro(string marca, string modelo, int ano) 
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Ano { get; set; }    

}