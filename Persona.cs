﻿class Persona
{
    //Atributos
    public string Nombre { get; set; }
    public int Edad { get; set; }

    //Constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    //Metodos

    public virtual void MostrarInteres()
    {
        Console.WriteLine($"{Nombre} muestra su interes");
    }

    public virtual void ExpresarSentimientoss()
    {
        Console.WriteLine($"{Nombre} expresa sus sentimientos");
    }

    //Sobrecarga de +

    /*public static Persona operator +(Persona p1, Persona p2, Persona p3)
    {
        if (p1.GetType() == p2.GetType() && p1.GetType() == p3.GetType())
        {
            Console.WriteLine($"{p1.Nombre} & {p2.Nombre} & {p3.Nombre} son una pareja perfecta, felicidades!!");
        }

        else 
        {
            Console.WriteLine($"{p1.Nombre} & {p2.Nombre} & {p3.Nombre} son son compatibles pueden ser buenos amigos");

        }

        return new Persona( $"{p1.Nombre} & {p2.Nombre} & {p3.Nombre} tienen un promedio de edad:",p1.Edad + p2.Edad +p3.Edad/3);
    }*/
}
