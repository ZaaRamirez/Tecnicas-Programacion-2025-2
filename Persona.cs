class Persona
{
    public string Nombre { get; private set; }
    public int Edad { get; private set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public virtual void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} muestra interés en alguien aq uien le gusta.");
    }

    public virtual void ExpresarSentimientos()
    {
        Console.WriteLine($"{Nombre} expresa sus sentimientos de manera única.");
    }

    // 📌 Sobrecarga del operador + para dos personas
    public static Persona operator +(Persona p1, Persona p2)
    {
        if (p1.GetType() == p2.GetType())
        {
            Console.WriteLine(p1.GetType());
            Console.WriteLine($"💖 {p1.Nombre} y {p2.Nombre} forman una pareja en Cupidópolis. ¡Felicidades! 💞");
            return new Persona($"{p1.Nombre} & {p2.Nombre}", (p1.Edad + p2.Edad) / 2);
        }
        else
        {
            Console.WriteLine(p1.GetType());
            Console.WriteLine($"💔 {p1.Nombre} y {p2.Nombre} no son compatibles, pero pueden ser buenos amigos.");
            return new Persona($"{p1.Nombre} & {p2.Nombre}", (p1.Edad + p2.Edad) / 2);
        }
    }

    // 📌 Método para sumar tres personas verificando que sean del mismo tipo
    public static Persona SumarTres(Persona p1, Persona p2, Persona p3)
    {
        if (p1.GetType() == p2.GetType() && p1.GetType() == p3.GetType())
        {
            Console.WriteLine($"💞 {p1.Nombre}, {p2.Nombre} y {p3.Nombre} han formado un trío inseparable en Cupidópolis.");
            return new Persona($"{p1.Nombre}, {p2.Nombre} & {p3.Nombre}", (p1.Edad + p2.Edad + p3.Edad) / 3);
        }
        else
        {
            Console.WriteLine($"💔 {p1.Nombre}, {p2.Nombre} y {p3.Nombre} no pueden formar un trío, pero siguen siendo amigos.");
            return new Persona($"{p1.Nombre}, {p2.Nombre} & {p3.Nombre}", (p1.Edad + p2.Edad + p3.Edad) / 3);
        }
    }
}



