IAnimal animal1 = new Cachorro();
IAnimal animal2 = new Gato();

animal1.FazerSom();


public interface IAnimal
{
    public void FazerSom();

}

public class Cachorro : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Au");
    }   
    public void QuantidadePatas()
    {
        Console.WriteLine("Tem 4 patas");
        
    }
}

public class Gato : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Miau");
    }

}


