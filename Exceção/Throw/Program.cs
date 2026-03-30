
// Tratando erro usando throw
try
{
    A.executandoA();
 


}
catch (Exception ex)
{
    Console.WriteLine($"A exceção foi tratada na chamada de A: {ex.Message}");
}
class A
{
    public static void executandoA()
    {
        //try
        //{
            B.executandoB();


        //}
        //catch (Exception ex) 
        //{
        //    Console.WriteLine($"A exceção foi tratada na classe A: {ex.Message}");
        //}
    }
}
class B
{
    public static void executandoB()
    {
        //try
        //{
            C.executandoC();

        //}
        //catch (Exception ex) 
        //{
        //    Console.WriteLine($"A exceção foi tratada na classe B: {ex.Message}");
        //}       
    }
}
class C
{
    public static void executandoC()
    {
        // O throw procura um try catch, se ele encontrar ele roda o catch existente, se ele não encontrar ele roda o seu tratamento.
        throw new NotImplementedException("O método não foi implementado");
    }
}