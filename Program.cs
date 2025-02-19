Banco banco = new Banco();

try
{
    
    CuentaBancaria cuentaOrigen = banco.BuscarCuenta("12345");

    CuentaBancaria cuentaDestino = banco.BuscarCuenta("67890");

    Console.WriteLine("Transferencia:");
    Console.WriteLine($"Saldo inicial: {cuentaOrigen.Saldo}");

    cuentaOrigen.Transferir(cuentaDestino, 10);

    Console.WriteLine($"Saldo restante: {cuentaOrigen.Saldo}");

    Console.WriteLine("Deposito:");
    Console.WriteLine($"Saldo inicial: {cuentaOrigen.Saldo}");

    cuentaOrigen.Depositar(10000);

    Console.WriteLine($"Saldo restante: {cuentaOrigen.Saldo}");

    Console.WriteLine("Retiro:");
    Console.WriteLine($"Saldo inicial: {cuentaOrigen.Saldo}");

    cuentaOrigen.Retirar(556);

    Console.WriteLine($"Saldo restante: {cuentaOrigen.Saldo}");
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}
catch (CuentaNoEncontradaException e)
{
    Console.WriteLine(e.Message);
}
catch (DepositoInvalidoException e)
{
    Console.WriteLine(e.Message);
}


