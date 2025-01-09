// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// int[] arrayInteirosDobrados = new int[6];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);


// for(int contador = 0; contador < arrayInteirosDobrados.Length; contador++) {
//     Console.WriteLine($"Indice {contador} = {arrayInteirosDobrados[contador]}");
// }

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// for(int contador = 0; contador < arrayInteiros.Length; contador++) {
//     Console.WriteLine($"Indice {contador} = {arrayInteiros[contador]}");
// }

// foreach(int valor in arrayInteiros) {
//     Console.WriteLine(valor);
// }

// ------------------- Lstas -----------------

List<String> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

// for(int contador = 0; contador <= listaString.Count; contador++) {
//     Console.WriteLine($"Posição {contador} = {listaString[contador]}");
// }

foreach(string item in listaString) {
    Console.WriteLine(item);
}