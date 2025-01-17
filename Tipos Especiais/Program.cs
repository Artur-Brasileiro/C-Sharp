//TIPO NULO
// bool? desejaReceberEmail = null;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou não optou por receber e-mail");
// }

//TIPO ANONIMO
// var tipoAnonimo = new {Nome = "Artur", Sobrenome = "Brasileiro", Altura = 1.80};

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");

//TIPO DINAMICO
// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

//CLASSE GENERICA
// using Tipos_Especiais.Models;

// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdicionarElementoArray("Artur");
// Console.WriteLine(arrayString[0]);

//MÉTODOS DE EXTENSÃO
using Tipos_Especiais.Models;

int numero = 15;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + "é " + (par ? "par" : "ímpar");
Console.WriteLine(mensagem);