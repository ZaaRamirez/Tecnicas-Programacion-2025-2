// Programa estrucutrado para el calculo del factorial de un número

Console.WriteLine("Ingrese numero entero");
int numero = int.Parse(Console.ReadLine() ?? "");
int f = 1;
if (numero < 0)
{
    Console.WriteLine("No se puede calcular el factorial de un número negativo");
}
else
{
    for (int i = 1; i <= numero; i++)
    {
        f = f * i;
        //f *= i;
    }
}
Console.WriteLine($"El resultado es: {f}");
