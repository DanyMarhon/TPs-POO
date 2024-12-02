public class Sumador
{
    private int cantidadSumas;

    public int CantidadSumas { get { return cantidadSumas; } }

    public Sumador(int cantidadSumas)
    {
        this.cantidadSumas = cantidadSumas;
    }
    public Sumador()
    {
        this.cantidadSumas = 0;
    }

    public int Sumar(int X, int Y)
    {
        cantidadSumas++;
        return (X + Y);
    }

    public string Sumar(string X, string Y)
    {
        cantidadSumas++;
        return (X + Y);
    }

    public static bool operator ==(Sumador s1, Sumador s2)
    { return s1.cantidadSumas == s2.cantidadSumas; }

    public static bool operator !=(Sumador s1, Sumador s2)
    { return !(s1 == s2); }

    public override bool Equals(object? obj)
    {
        if (!(obj is Sumador) || (obj is null)) { return false; }

        return this == (Sumador)obj;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Sumador s1 = new Sumador();
        s1.Sumar(8, 5);
        s1.Sumar(8, 5);
        s1.Sumar(8, 5);

        Sumador s2 = new Sumador();
        s2.Sumar(8, 5);
        s2.Sumar(8, 5);

        Console.WriteLine($"La cantidad de sumas es igual? \n {s1 == s2}");

        s2.Sumar(8, 5);

        Console.WriteLine($"La cantidad de sumas es igual? \n {s1 == s2}");
    }
}