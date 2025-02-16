class CalculadoraCientifica : Calculadora
{
    public CalculadoraCientifica(int num1, int num2) : base(num1, num2) { }

    public double RaizCuadrada()
    {
        return Math.Sqrt(Numero1);
    }

    public double Logaritmo()
    {
        return Math.Log(Numero1);
    }
}
