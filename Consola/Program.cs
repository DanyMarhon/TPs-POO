using Datos;
using Entidades;

public class Program
{
    public static void Main(string[] args)
    {
        Equipo e1 = new Equipo(11,"Insti");
        Equipo e2 = new Equipo(11, "Insti");
        Equipo e3 = new Equipo(11, "Insti2");
        Jugador j1 = new Jugador(40377284, "Daniel");

        Console.WriteLine(j1.MostrarDatos());
        Console.WriteLine(e1.MostrarDatosEquipo());

        e1 += j1;
        Console.WriteLine(e1.MostrarDatosEquipo());

        Console.WriteLine(e3==e2);
    }
}