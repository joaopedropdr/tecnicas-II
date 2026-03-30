ContaBancaria conta = new(1000.50m);
try
{
    conta.Sacar("1001");

}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro de sasldo {ex.Message}");
}
// Tratando erro com throw personalizado
public class ContaBancaria
{
    public decimal Saldo { get; private set; }
    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }
    public void Sacar(string valorTexto)
    {
        try
        {
            decimal valor = decimal.Parse(valorTexto);
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException($"Saldo insuficiente. Saldo atual: {Saldo} " + $"Tentativa de saque no valor de {valor}");
            }
            Saldo -= valor;
            Console.WriteLine($"Saldo atual {Saldo}");
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Erro ao converter o valor do saque", ex);
        }
        finally
        {
            Console.WriteLine("Fim do saque");
        }
    }
}

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException()
    {
        
    }
    public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
    public SaldoInsuficienteException(string mensagem, Exception innerException):base(mensagem, innerException) {}
}