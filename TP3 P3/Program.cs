public class Dolar
{
    public static double CotizacionUSD { get; set; }
    public double Cantidad { get; set; }

    static Dolar()
    {
        CotizacionUSD = 1;
    }

    public Dolar(double cantidad)
    {
        Cantidad = cantidad;
    }

    public Dolar(double cantidad, double cotizacion)
    {
        Cantidad = cantidad;
        CotizacionUSD = cotizacion;
    }

    public static implicit operator Dolar(double v)
    {
        return new Dolar(v);
    }

    public static explicit operator Dolar(Peso p)
    {
        var cantidadEnUSD = p.Cantidad / Peso.CotizacionUSD;
        return new Dolar(cantidadEnUSD);
    }

    public static bool operator ==(Dolar d, Peso p)
    {
        var d2 = (Dolar)p;
        return d.Cantidad == d2.Cantidad;
    }

    public static bool operator !=(Dolar d, Peso p) { return !(d == p); }

    public static Dolar operator +(Dolar d, Peso p)
    {
        Dolar d2 = (Dolar)p;
        return new Dolar(d.Cantidad + d2.Cantidad);
    }

    public static Dolar operator -(Dolar d, Peso p)
    {
        Dolar d2 = (Dolar)p;
        return new Dolar(d.Cantidad - d2.Cantidad);
    }

    public override string ToString()
    {
        return $"{Cantidad}";
    }


}

public class Peso
{
    public static double CotizacionUSD { get; set; }
    public double Cantidad { get; set; }

    static Peso()
    {
        CotizacionUSD = 1100;
    }

    public Peso(double cantidad)
    {
        Cantidad = cantidad;
    }

    public Peso(double cantidad, double cotizacion)
    {
        Cantidad = cantidad;
        CotizacionUSD = cotizacion;
    }

    public static implicit operator Peso(double v)
    {
        return new Peso(v);
    }

    public static explicit operator Peso(Dolar d)
    {
        var cantidadEnPesos = Peso.CotizacionUSD * d.Cantidad;
        return new Peso(cantidadEnPesos);
    }

    public static bool operator ==(Peso p, Dolar d)
    {
        var p2 = (Peso)d;
        return p.Cantidad == p2.Cantidad;
    }

    public static bool operator !=(Peso p, Dolar d) { return !(d == p); }

    public static Peso operator +(Peso p, Dolar d)
    {
        Peso p2 = (Peso)d;
        return new Peso(p.Cantidad + p2.Cantidad);
    }

    public static Peso operator -(Peso p, Dolar d)
    {
        Peso p2 = (Peso)d;
        return new Peso(p.Cantidad - p2.Cantidad);
    }

    public override string ToString()
    {
        return $"{Cantidad}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dolar d = new Dolar(1);
        Peso p = new Peso(1100);

        if (d == p)
        {
            Console.WriteLine("Son iguales");
        }
        else
        {
            Console.WriteLine("No son iguales");
        };

        var suma = d + p;
        var suma2 = p + d;

        Console.WriteLine(suma);
        Console.WriteLine(suma2);
    }
}