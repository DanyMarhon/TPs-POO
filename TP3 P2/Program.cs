using System.Text;

public class Fraccion
{
    public int Numerador { get; set; }
    public int Denominador { get; set; }

    public Fraccion(int numerador, int denominador)
    {
        //if (denominador == 0) {throw new ArgumentException("El denominador no puede ser cero.");}
        Numerador = numerador;
        Denominador = denominador;
    }

    public Fraccion(int numerador)
    {
        Numerador = numerador;
        Denominador = 1;
    }
    public static string MostrarFraccion(Fraccion f)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{f.Numerador} / {f.Denominador}");
        return sb.ToString();
    }

    public static bool Validador(string x, string y)
    {
        bool valid = false;
        if (int.TryParse(x, out _))
        {
            if (int.TryParse(y, out int d) && (d != 0))
            {
                valid = true;
            }
        }
        return valid;
    }

    public static bool operator ==(Fraccion f1, Fraccion f2)
    {
        return f1.Numerador == f2.Numerador && f1.Denominador == f2.Denominador;
    }

    public static bool operator !=(Fraccion f1, Fraccion f2)
    {
        return (!(f1 == f2));
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Fraccion)) { return false; }
        return (this == (Fraccion)obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public static implicit operator Fraccion(int v)
    {
        return new Fraccion(v, 1);
    }

    public static explicit operator string(Fraccion f)
    {
        return $"{f.Numerador.ToString()} / {f.Denominador.ToString()}";
    }

    public override string ToString()
    {
        return $"{Numerador} / {Denominador}";
    }

    public static explicit operator Fraccion(string s)
    {
        var partes = s.Split('/');
        Fraccion f = new Fraccion(1);
        f.Numerador = int.Parse(partes[0]);
        f.Denominador = int.Parse(partes[1]);
        return f;
    }

    public static double ToDecimal(Fraccion f)
    {
        double resultado = ((double)f.Numerador / (double)f.Denominador);
        return (resultado);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var f = new Fraccion(5);
        Console.WriteLine(f.ToString());

        f = 9;
        Console.WriteLine(f);

        string Ingreso = ("5/6");
        f = (Fraccion)Ingreso;
        Console.WriteLine(f);

        Console.WriteLine(Fraccion.MostrarFraccion(f));

        Console.WriteLine(Fraccion.ToDecimal(f).ToString());

        //double numero = 5.55;
        //Console.WriteLine(numero);

        ////conversion explícita
        //int entero = (int)numero;
        //Console.WriteLine(entero);

        ////conversion implícita
        //double decima = entero;
        //Console.WriteLine(decima);
    }
}