var caminho = @"c:\tecnicas-II\teste.txt";
if(!File.Exists(caminho))
{
    File.WriteAllText(caminho, "Autor desconhecido");
}
var novoTexto = "\r\n Quem canta seus males espanta " + Environment.NewLine + "àgua mole pedra dura tanto bate até que fura\r\n Casa de ferreiro ";
File.AppendAllText(caminho, novoTexto);
string conteudo = File.ReadAllText(caminho);
Console.WriteLine(conteudo);
