//Declarando un arreglo con tamaño explicito

using static System.Runtime.InteropServices.JavaScript.JSType;

int[] numeros = new int[2];

//Asignar valores a elementos
numeros[1] = 8;

Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[0]);

if (numeros[1] == 8)
{
    Console.WriteLine($"El numero es:{numeros[1]}");
}

//Obtener la longitud del arreglo

Console.WriteLine(numeros.Length);

//Arreglo con tamaño implicito

int[] numerosV2 = new int[] { 4, 5, 6 };
int[] numerosV3 = { 10, 6, 358, 2 };

foreach (int numero in numerosV3)
{
    Console.WriteLine($"{numero}");
}

char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

foreach (char vocal in vocales)
{
    Console.Write($"{vocal}");
}

bool[] estados = new bool[2];
estados[0] = true;
estados[1] = false;

Console.WriteLine($"{estados[0]}");

if (estados[0])
{
    Console.WriteLine("Es verdadero");
}

//Ordenarlos de mayor a menor

Console.WriteLine("Arreglo desordenado");

foreach (int numero in numerosV3)
{
    Console.WriteLine($"{numero}");
}

Array.Sort(numerosV3);

Console.WriteLine("Arreglo ordenado de menor a mayor");

foreach (int numero in numerosV3)
{
    Console.WriteLine($"{numero}");
}

Console.WriteLine(Array.BinarySearch(numerosV3, 4));

//Arreglo ordenado de mayor a menor

Array.Reverse(numerosV3);

Console.WriteLine("Arreglo ordenado de mayor a menor");

foreach (int numero in numerosV3)
{
    Console.WriteLine($"{numero}");
}

//Buscar un valor dado un arreglo Debe estar ordenado

//Array.BinarySearch(numerosV3,358);
