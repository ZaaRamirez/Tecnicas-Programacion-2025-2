/*//Programa orientado a objetos

Console.WriteLine("Ingresa el nombre: ");
string nombreO = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la edad: ");
int edadO = int.Parse(Console.ReadLine() ?? "");

//Crear objeto
Persona.MostrarPais();
Persona enteAlienQueDefini = new Persona(nombreO, edadO, "Mexico");
enteAlienQueDefini.MostrarDatos();

Persona humano2 = new Persona("Pablo", 35, "Mexico");
humano2.MostrarDatos();

humano2.Edad = 40;
Persona.Pais = "España";
humano2.MostrarDatos();
Persona.MostrarPais();*/

/*// Crear un objeto de la clase Calculadora
Calculadora calc = new Calculadora(10, 0);

// Usar los métodos de la clase
Console.WriteLine($"Suma: {calc.Sumar()}");
Console.WriteLine($"Resta: {calc.Restar()}");
Console.WriteLine($"Multiplicación: {calc.Multiplicar()}");
Console.WriteLine($"División: {calc.Dividir()}");
// Crear un objeto de la clase Calculadora
CalculadoraCientifica calc2 = new CalculadoraCientifica(10, 0);
Console.WriteLine($"División2: {calc2.Dividir()}");
Console.WriteLine($"División2: {calc2.RaizCuadrada()}");*/

Romantico juan = new Romantico("Juan", 25);
Romantico maria = new Romantico("María", 23);
Romantico ana = new Romantico("Ana", 24);
Independiente carlos = new Independiente("Carlos", 28);
juan.ExpresarSentimientos();
ana.ExpresarSentimientos();

// 📌 Intentamos formar parejas
Persona pareja1 = juan + maria; // Romántico + Romántico = 💖
Persona pareja2 = ana + carlos; // Amistoso + Independiente = 💔
Persona pareja3 = pareja1 + ana;

// 📌 Mostramos resultados
Console.WriteLine($"Nueva pareja: {pareja1.Nombre} (Edad promedio: {pareja1.Edad})");
Console.WriteLine($"Nueva pareja: {pareja3.Nombre} (Edad promedio: {pareja3.Edad})");
// Sumar tres personas
Persona trio = Persona.SumarTres(juan, maria, ana);