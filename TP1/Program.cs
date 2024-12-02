using System;
public class Cuadrado
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
    {
        Lado = lado;
    }
    public double CalcularArea()
    {
        return Lado * Lado;
    }

    public string EsCuadradoPerfecto()
    {
        bool valido = false;
        double n1 = (Math.Sqrt(Lado));
        double n2 = (Math.Floor(n1));
        if (n1 == n2)
        {
            return "Es un cuadrado perfecto";
        }
        else return "No es un cuadrado perfecto";
    }

    public double DevolverDiagonal()
    {
        double diagonal = (Math.Sqrt(2) * Lado);
        return diagonal;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        var cuadrado = new Cuadrado(0);
        Console.WriteLine("Ingrese el valor del lado");

        cuadrado.Lado = double.Parse(Console.ReadLine());

        Console.WriteLine($"El área del cuadrado de valor {cuadrado.Lado} es:");
        Console.WriteLine(cuadrado.CalcularArea());
        
        Console.WriteLine($"La diagonal del cuadrado es:");
        Console.WriteLine(cuadrado.DevolverDiagonal());

        Console.WriteLine(cuadrado.EsCuadradoPerfecto());
        Console.ReadKey();
    }
}

