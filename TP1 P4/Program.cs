using System.ComponentModel.DataAnnotations;
using System.Text;

public class Temperatura
{
    private double gradosC { get; set; }
    public Temperatura(double gradosC)
    {
        this.gradosC = gradosC;
    }

    private bool Validar(double gradosC)
    {
        bool valido = false;
        if (gradosC >= -80 && gradosC <= 80) { valido = true; }
        return valido;
    }

    private (double, double) Convertir(double gradosC)
    {
        double fahrenheit = (gradosC * 1.8) + 32;
        double kelvin = gradosC + 273.15;
        return (fahrenheit, kelvin);
    }

    public string ObtenerDatos(double gradosC)
    {
        if (Validar (gradosC))
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{gradosC}°C equivalen a: ");
            sb.AppendLine($"{Convertir(gradosC).Item1}°F");
            sb.AppendLine($"{Convertir(gradosC).Item2}°K");
            return sb.ToString();
        }
        else
        {
            return "Datos invalidos";
        }
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor de los grados celcius");
        var gradosC = double.Parse(Console.ReadLine());
        Temperatura temperatura = new Temperatura(gradosC);
        Console.WriteLine(temperatura.ObtenerDatos(gradosC));
        Console.ReadKey();
    }
}
