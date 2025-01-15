//IF NORMAL
// int numero = 16;

// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {numero} é ímpar");
// }

//IF TERNÁRIO
int numero = 16;
bool ehPar;

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));