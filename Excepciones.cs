int numero;

Console.WriteLine("Este programa solamente divide 10 entre un numero positivo entero real");

try
{
    numero = int.Parse(Console.ReadLine() ?? "");

    if (numero < 0)
    {
        throw new ArgumentException("El numero no puede ser negativo");
    }

    double division = 10 / numero;
    Console.WriteLine($"La division de 10 / {numero} es: {division}");
}
catch (DivideByZeroException)
{
    Console.WriteLine($"No se puede dividir entre cero");
}
catch (ArgumentException)
{
    Console.WriteLine("El numero no puede ser negativo");
}
catch (FormatException)
{
    Console.WriteLine("El numero ingresado no es valido");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("El programa terminó");
}