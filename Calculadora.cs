public class Calculadora
{
    //Atributos
    public int numero1 { get; set; }
    public int numero2 { get; set; }

    //Atributo privado
    private int _resultado { get; set; }
    protected string mensaje = "Mensaje protegido";

    //Constructor

    public Calculadora(int num1, int num2)
    {
        numero1 = num1;
        numero2 = num2;
    }

    //Sobrecarga del operador +
    public static Calculadora operator +(Calculadora c1, Calculadora c2)
    {
        return new Calculadora(c1.numero1 + c2.numero1, c1.numero2 + c2.numero2);
    }

    //Metodos

    public virtual int Sumar()
    {
        _resultado = numero1 + numero2;
        return _resultado;
    }

    public int Sumar(int num3)
    {
        _resultado = numero1 + numero2 + num3;
        return _resultado;
    }

    public int Restar()
    {
        return numero1 - numero2;
    }

    public int Multiplicar()
    {
        return numero1 * numero2;
    }

    public double Dividir()
    {
        if (numero2 == 0)
        {
            Console.WriteLine("No se puede divir entre 0");
            return 0;
        }

        return (double) numero1 / numero2;
    }

    //Metodo privado 
    private void MostrarMensaje()
    {
        Console.WriteLine(mensaje);
    }

    //Metodo protegido
    protected void Reiniciar()
    {
        numero1 = 0;
        numero2 = 0;
        _resultado = 0;
        Console.WriteLine("Calculadora reiniciada");
    }

    public void MostrarResultado()
    {
        Console.WriteLine($"El resultado es: {_resultado}");
    }

}
