using Entidades;
using System.Timers;

RepoPrimos rp = new RepoPrimos(3);

bool ciclo = true;
do
{
    Console.WriteLine("Ingrese un número primo para agregar al repo");

    if (int.TryParse(Console.ReadLine(), out int valor) && Primo.EsPrimo(valor))
    {
        Primo primo = new Primo(valor); // ✅ Crear un nuevo objeto aquí
        Console.WriteLine($"Número primo {valor} creado");

        if (rp + primo) // ✅ Se asume que + devuelve bool
        {
            Console.WriteLine("Número añadido al repo");
        }
        else
        {
            Console.WriteLine("Repo lleno o número repetido");
        }
    }
    else
    {
        Console.WriteLine("Número no es primo o entrada no válida");
    }

    Console.WriteLine("Desea ingresar más números? (Y/N)");
    var respuesta = Console.ReadLine();
    if (respuesta.Equals("N", StringComparison.OrdinalIgnoreCase))
    {
        ciclo = false;
    }
} while (ciclo);


Console.WriteLine(rp.MostrarNumeros(rp));

