using System.Text;

public class Punto
{
    public double X { get; set; }
    public double Y { get; set; }
    public Punto(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public static double ObtenerDistanciaEntrePuntos(Punto p1, Punto p2)
    {
        return Math.Sqrt((Math.Pow((p1.X - p2.X), 2) + (Math.Pow((p1.Y - p2.Y), 2))));
    }

    public static bool SonColineales(Punto p1, Punto p2, Punto p3)
    {
        double area = Math.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2.0;
        return area == 0;
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el de X seguido del de Y para el primer punto");
        var X1 = double.Parse(Console.ReadLine());
        var Y1 = double.Parse(Console.ReadLine());
        Punto p1 = new Punto(X1, Y1);

        Console.WriteLine("Ingrese el de X seguido del de Y para el segundo punto");
        var X2 = double.Parse(Console.ReadLine());
        var Y2 = double.Parse(Console.ReadLine());
        Punto p2 = new Punto(X2, Y2);

        var sb = new StringBuilder();
        Console.WriteLine(sb.AppendLine($"La distancia entre los puntos {p1.X},{p1.Y} y {p2.X},{p2.Y} es de {Punto.ObtenerDistanciaEntrePuntos(p1,p2).ToString()}"));

        Console.WriteLine("Desea editar el primer punto? \n Responder con Y / N");
        string respuesta = Console.ReadLine();

        if (respuesta == "Y")
        {
            Console.WriteLine("Ingrese el de X seguido del de Y para el primer punto");
            p1.X = double.Parse(Console.ReadLine());
            p1.Y = double.Parse(Console.ReadLine());

            Console.WriteLine(sb.AppendLine($"La nueva distancia entre los puntos {p1.X},{p1.Y} y {p2.X},{p2.Y} es de {Punto.ObtenerDistanciaEntrePuntos(p1,p2).ToString()}"));
        }

        Console.WriteLine("Desea verificar la colinealidad con un tercer punto? \n Responder con Y / N");
        respuesta = Console.ReadLine();
        if (respuesta == "Y")
        {
            Console.WriteLine("Ingrese el de X seguido del de Y para el tercer punto");
            var X3 = double.Parse(Console.ReadLine());
            var Y3 = double.Parse(Console.ReadLine());
            Punto p3 = new Punto(X3, Y3);

            if (Punto.SonColineales(p1,p2,p3))
            {
                Console.WriteLine("Los 3 puntos son colineales");
            }
            else { Console.WriteLine("Los 3 puntos son colineales");}
        }
        Console.ReadKey();
    }
}
