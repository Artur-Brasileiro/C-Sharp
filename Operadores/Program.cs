// int a = 10;
// int b = 20;
// int c = a + b;
// Console.WriteLine(c);

// c += 5;
// Console.WriteLine(c);

// c -= 5;
// Console.WriteLine(c);

// c /= 5;
// Console.WriteLine(c);

// c *= 5;
// Console.WriteLine(c);

// C O N V E R S Ã O

// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();

// CONVERSÃO COM SEGURANÇA

string a = "5-";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(b);