string apresentacao = "Olá, seja bem vindo!";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80m;

bool condicao = true;

Console.WriteLine("String: " + apresentacao);
Console.WriteLine("Int: " + quantidade);
Console.WriteLine("Double: " + altura);
Console.WriteLine("Decimal: " + preco);
Console.WriteLine("Booleano: " + condicao);

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataAtualSomada = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtualSomada.ToString("dd/MM/yyyy MM:mm"));
