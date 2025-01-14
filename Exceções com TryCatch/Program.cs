try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivosLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu um erro genérico. {ex.Message}");
}
finally
{
    Console.WriteLine("O código passou do try catch!");
}



