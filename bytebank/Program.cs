using bytebank.Titular;
using bytebank.Contas;
using bytebank;
using System.Numerics;

using (LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt"))
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}

/*LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt");
//try
//{
//    leitor.LerProximaLinha();
//    leitor.LerProximaLinha();
//}
//catch (IOException)
//{
//    Console.WriteLine("Leitura de arquivo interrompida.");
//    Console.WriteLine("Exceção do tipo IOException capturada e tratada");
//}
//finally
//{
//    leitor.Fechar();
}*/

/*
try
{
    ContaCorrente conta1 = new ContaCorrente(4564, "1234-X");
    ContaCorrente conta2 = new ContaCorrente(7891, "456794");

    conta1.Transferir(10000, conta2);
    //conta1.Sacar(10000);

    //conta1.Sacar(50);
    //Console.WriteLine(conta1.GetSaldo());
    //conta1.Sacar(150);
    //Console.WriteLine(conta1.GetSaldo());
}
catch(ArgumentException ex) 
{
    Console.WriteLine($"Parâmetro com erro: {ex.ParamName}"); //mostra o nome do argumento que está lançando a exceção 
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero.");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente!");
    Console.WriteLine(ex. Message);
}
catch(OperacaoFinanceiraException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);

    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
    Console.WriteLine(e.InnerException.Message);
    Console.WriteLine(e.InnerException.StackTrace);
}
*/
Console.ReadKey();