// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade no estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar essa venda? {possivelVenda}");


//  if (quantidadeCompra == 0){
//     Console.WriteLine("Venda inválida.");
// } else if (possivelVenda) {
//     Console.WriteLine("Venda realizada.");
// } else {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada estoque.");
// }

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch(letra) {
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}