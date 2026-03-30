// Tratamento de exceção 
try
{
Console.WriteLine("Digite o Dividendo");
int dividendo = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Digite o Divisor");
int divisor = Convert.ToInt32( Console.ReadLine() );
var resultado = dividendo / divisor;
Console.WriteLine($"O resultado de {dividendo} dividido por {divisor} é {resultado}");

}
// Tratamento de erros com o catch
// Erro de formato/tipo diferente
catch (FormatException)
{
    Console.WriteLine("Os valores devem ser inteiros");
}
// Pega a exceção generica e especifica ela com o when
// Trata o mesmo que a de cima, o formato/tipo
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Entre com valores inteiros");   

}
// Mensagem de erro caso o divisor for 0
catch (DivideByZeroException)
{
    Console.WriteLine("Divisor não pode ser zero!");
}
// Menssagem de erro genérica 
// Usada quando existe varios tipos de erro. Usado normalmente para pegar a menssagem de erro no BD.
catch (Exception ex)
{
    Console.WriteLine($"Problema na divisão: {ex.Message}");
}
// Menssagem de finalização 
finally 
{
    Console.WriteLine("Acabou a divisão");
}