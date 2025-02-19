
class CuentaBancaria
{
    //Atributos o propiedades
    public string NumeroCuenta { get; }

    public decimal Saldo { get; set; }

    //Constructor

    public CuentaBancaria(string numeroCuenta, decimal saldo)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    //Metodos

    public void Depositar(decimal cantidad)
    {
        if (cantidad <0)
        {
            throw new DepositoInvalidoException("No puedes depositar una cantidad negativa");
            
        }
        Saldo += cantidad;
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad > Saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente");
        }

        Saldo -= cantidad;
    }

    public void Transferir(CuentaBancaria destino, decimal cantidad)
    {
        if (destino == null)
        {
            throw new CuentaNoEncontradaException("Cuenta destino no encontrada");
        }

        Retirar(cantidad);
        destino.Depositar(cantidad);
    }
}
