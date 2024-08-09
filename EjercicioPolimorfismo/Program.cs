// Solicitar información al usuario
using EjercicioPolimorfismo;
Console.WriteLine("Este programa funciona con polimorfismo con animales");
Console.WriteLine("a continuacion se le solicita llenar los siguientes datos:");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Ingrese la raza del perro: ");
string razaPerro = Console.ReadLine();

Console.WriteLine("Ingrese la raza del gato: ");
string razaGato = Console.ReadLine();

Console.WriteLine("Ingrese la raza del pollo: ");
string tipoAve = Console.ReadLine();

// Crear instancias de las clases con la información proporcionada
Perro miPerro = new Perro(razaPerro);
Gato miGato = new Gato(razaGato);
Pajaro miPajaro = new Pajaro(tipoAve);

Console.WriteLine("");
Console.WriteLine("");

// Demostración de polimorfismo mediante sobrecarga de métodos
miPerro.Comunicar();
miPerro.Comer("croquetas");

miGato.Comunicar();
miGato.Comer("pescado");

miPajaro.Comunicar();
miPajaro.Comer("semillas");

Console.ReadLine();