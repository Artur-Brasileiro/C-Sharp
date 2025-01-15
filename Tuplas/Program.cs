// formas de criar uma tupla (usar sempre a segunda)
// (int, string, string, decimal) tupla1 = (1, "Artur", "Brasieiro", 1.80M);
// Console.WriteLine($"Id: {tupla1.Item1}");
// Console.WriteLine($"Nome: {tupla1.Item2}");
// Console.WriteLine($"Sobrenome: {tupla1.Item3}");
// Console.WriteLine($"Altura: {tupla1.Item4}");

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla2 = (1, "Artur", "Brasieiro", 1.80M);

// ValueTuple<int, string, string, decimal> tupla3 = (1, "Artur", "Brasieiro", 1.80M);

// var tupla4 = Tuple.Create(1, "Artur", "Brasieiro", 1.80M);

using Tuplas.Models;

LeituraArquivos arquivo = new LeituraArquivos();

// usa-se "_" para descartar uma informação da tupla, por exemplo:
var (sucesso, linhasArquivo, _) = arquivo.LerArquivos("Arquivos/TextoLeitura.txt");

if(sucesso)
{
    //Console.WriteLine($"Quantidade linhas do arquivo: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível realizar a leitura!");
}