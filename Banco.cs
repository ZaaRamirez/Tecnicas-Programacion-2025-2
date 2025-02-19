class Banco
{
    //Atributos
    private CuentaBancaria[] cuentas;

    //Constructor 
    public Banco()
    {
        cuentas = new CuentaBancaria[]
            {
                new CuentaBancaria("12345",100),
                new CuentaBancaria("67890",500),
            };
    }

    //Metodo
    public CuentaBancaria BuscarCuenta(string numeroCuenta)
    {
        foreach (CuentaBancaria cuenta in cuentas)
        {
            if (cuenta.NumeroCuenta == numeroCuenta)
            { 
                return cuenta;
            }
        }

        return null;
    }
}
