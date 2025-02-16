using System;

class Calculadora
{
    // Atributos
    public int Numero1 { get; set; }
    public int Numero2 { get; set; }

    // Constructor
    public Calculadora(int num1, int num2)
    {
        Numero1 = num1;
        Numero2 = num2;
    }

    // Métodos
    public int Sumar()
    {
        return Numero1 + Numero2;
    }

    public int Restar()
    {
        return Numero1 - Numero2;
    }

    public int Multiplicar()
    {
        return Numero1 * Numero2;
    }

    public double Dividir()
    {
        if (Numero2 == 0)
        {
            //throw new DivideByZeroException("No se puede dividir por cero.");
            return 0;
        }
        return (double)Numero1 / Numero2;
    }
}

