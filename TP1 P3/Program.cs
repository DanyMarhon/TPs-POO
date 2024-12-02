using System.ComponentModel.DataAnnotations;

public class Rectangulo
{
    public double Altura { get; set; }
    public double Anchura { get; set; }
    public Rectangulo()
    {
        
    }
    public Rectangulo(double altura, double anchura)
    {
        Altura = altura;
        Anchura = anchura;
    }

    public (bool, string) VerificarRectangulo()
    {
        if (Altura >= 0 && Anchura >= 0)
        {
            return (true, "El rectángulo es válido");
        }
        return (false, "El rectángulo no es válido");
    }
    public string VerificarPunto(double puntoX, double puntoY)
    {
        if (Altura >= puntoY && Anchura >= puntoX) 
        {
            return "El punto se encuentra dentro del rectángulo";
        }
        return "El punto no se encuentra dentro del rectángulo";
    }
}
public class Program
{
    static void Main(string[] args)
    {
        var rectangulo = new Rectangulo();
        Console.WriteLine("Ingrese el valor de la altura seguido del valor de la anchura");

        rectangulo.Altura = double.Parse(Console.ReadLine());
        rectangulo.Anchura = double.Parse(Console.ReadLine());

        bool resultado = rectangulo.VerificarRectangulo().Item1;
        if (resultado)
        {
            Console.WriteLine(rectangulo.VerificarRectangulo().Item2.ToString());
            Console.WriteLine($"Vamos a verificar si un punto esta dentro del rectangulo");
            Console.WriteLine($"Ingrese el valor X del punto a verificar seguido del valor Y");
            double puntoX = double.Parse(Console.ReadLine());
            double puntoY = double.Parse(Console.ReadLine());
            Console.WriteLine(rectangulo.VerificarPunto(puntoX, puntoY));
        }
        else { Console.WriteLine(rectangulo.VerificarRectangulo().Item2.ToString()); }
    }
}

