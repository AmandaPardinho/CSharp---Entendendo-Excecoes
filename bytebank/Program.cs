using bytebank.Titular;
using bytebank.Contas;

try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
}
catch(ArgumentException ex) 
{
    Console.WriteLine(ex.ParamName); //mostra o nome do argumento que está lançando a exceção 
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero.");
    Console.WriteLine(ex.Message);
}
Console.ReadKey();