
class CalculadoraCientifica : Calculadora
{

    //Constructor
    public CalculadoraCientifica(int nume1, int nume2) : base (nume1, nume2) { }

    //Metodos

    //Override cambia metodo heredado de Sumar
    public override int Sumar()
    {
        int suma = base.Sumar();
        return suma * suma;
    }

    public int Factorial()
    {
        int f = 1;

        if (numero1 < 0)
        {
            Console.WriteLine("No se puede calcular el factorial de un número negativo");
            return 0;
        }

        for (int i = 1; i <= numero1; i++)
        {
            f = f * i;
        }

        return f;
    }

    public double Logaritmo()
    {
        return Math.Log(numero1);
    }
    
    //Mostrar mensaje protegido
    public void MensajedeCalculadora()
    {
        Console.WriteLine(mensaje);
    }

    public void ReiniciarCalculadora()
    {
        Reiniciar();
    }
}
