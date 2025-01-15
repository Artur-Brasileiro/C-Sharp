using Newtonsoft.Json;
using Serialização__JSON_.Models;

//SERIALIZANDO UM ARQUIVO
// List<Venda> listaVendas = new List<Venda>();

// DateTime dataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

//DESERIALIZANDO UM ARQUIVO
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco:C}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}