// int numero1 = 10;
// string numero2 = "20";
// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);
// Neste codigo "resultado" recebe o valor "1020.

// using System.Globalization;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 12423582.40M;
// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// DateTime data = DateTime.Now;
//Formatação personalizada
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
//Apenas data
// Console.WriteLine(data.ToShortDateString());
//Apenas hora
// Console.WriteLine(data.ToShortTimeString());

//CONVERSÃO NÃO SEGURA
// string dataString = "2025-01-13 20:00";
// DateTime data = DateTime.Parse(dataString);
// Console.WriteLine(data);

//CONVERSÃO SEGURA
using System.Globalization;

string dataString = "2025-01-13 20:00";
bool sucesso = DateTime.TryParseExact(
    dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if(sucesso) 
{
    Console.WriteLine($"Convertido com sucesso! Hora: {data}");
}
else
{
    Console.WriteLine("Não é uma data válida!");
}