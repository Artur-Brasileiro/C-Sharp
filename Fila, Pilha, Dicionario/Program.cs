// FILAS 
// Queue<int> fila = new Queue<int>();

//adicionando elementos à fila
// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);
// fila.Enqueue(6);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

//removendo elemento da fila
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

//PILHAS
// Stack<int> pilha = new Stack<int>();

//adicionando elementos na pilha
// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);
// pilha.Push(5);
// pilha.Push(6);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

//removendo elemento da pilha
// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

//  foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

//DICIONARIO
Dictionary<string, string> estados = new Dictionary<string, string>();

//adicionando elementos ao dicionario
estados.Add("SP", "São Paulo");
estados.Add("GO", "Goiás");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

//removendo elementos do dicionario
estados.Remove("SP");

Console.WriteLine("------------------------");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

//alterando valores do dicionario
estados["GO"] = "SEI LA FERA";

Console.WriteLine("------------------------");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

//verificando se o dicionario tem o valor
string chave = "GO";
if(estados.ContainsKey(chave))
{
    Console.WriteLine($"O dicionario contém a chave: {chave}");
}
else
{
    Console.WriteLine($"O dicionario NÃO contém a chave: {chave}");
}

//retornando o valor da chave
Console.WriteLine(estados["GO"]);