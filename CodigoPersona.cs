class Romantico : Persona
{
    public Romantico(string nombre, int edad) : base(nombre, edad) { }

    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} envía una carta de amor.");
    }

    public override void ExpresarSentimientos()
    {
        Console.WriteLine($"{Nombre} dedica un poema muy apasionado.");
    }
}

class Amistoso : Persona
{
    public Amistoso(string nombre, int edad) : base(nombre, edad) { }

    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} invita a tomar un café.");
    }

    public override void ExpresarSentimientos()
    {
        Console.WriteLine($"{Nombre} cuenta una historia divertida.");
    }
}

class Independiente : Persona
{
    public Independiente(string nombre, int edad) : base(nombre, edad) { }

    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} finge no notar el interés de los demás.");
    }

    public override void ExpresarSentimientos()
    {
        Console.WriteLine($"{Nombre} prefiere pasar tiempo a solas.");
    }
}
