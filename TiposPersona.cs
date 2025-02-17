
class Romantico : Persona
{
    //Constructor
    public Romantico (string nombre, int edad) : base (nombre, edad){ }

    //Metodos Override
    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} muestra su interes enviando una carta");
    }

    public override void ExpresarSentimientos()
    {
        Console.WriteLine($"{Nombre} expresa sus sentimientos dedicando un poema");
    }
}

class Amistoso : Persona
{
    //Constructor
    public Amistoso(string nombre, int edad) : base(nombre, edad) { }

    //Metodos Override
    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} muestra su interes invitando un cafe");
    }

    public override void ExpresarSentimientos()
    {
        Console.WriteLine($"{Nombre} expresa sus sentimientos compartiendo una historia divertida");
    }
}

class Indeferente : Persona
{
    //Constructor
    public Indeferente(string nombre, int edad) : base(nombre, edad) { }

    //Metodos Override
    public override void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} finge no mostrar su interes");
    }

    public override void ExpresarSentimientos()
    {
        Console.WriteLine($"{Nombre} prefiere estar solo");
    }
}