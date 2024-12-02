using System.Text;

public static class CalculadoraDeArea
{
    public static string CalcularArea(int tipo, double X, double? Y)
    {
        StringBuilder sb = new StringBuilder();
        switch (tipo)
        {
            case 1:
                sb.AppendLine($"El área del cuadrado es {X}");
                sb.AppendLine($"El perimetro del cuadrado es {X}");
                return sb.ToString();
            case 2:
                sb.AppendLine($"El área del Triángulo es {X * Y}");
                sb.AppendLine($"El perimetro del Triángulo es {X * Y}");
                return sb.ToString();
            case 3:
                sb.AppendLine($"El área del Círculo es {X}");
                sb.AppendLine($"El perimetro del Círculo es {X}");
                return sb.ToString();
            default:
                break;
        }
        return sb.ToString();
    }
}


public class Program
{
    static void Main(string[] args)
    {
        bool valido = false;
        int opcion = 0;
        double X = 0;
        double? Y = null;
        while (valido == false)
        {
            Console.WriteLine("Ingrese una opción\n" +
                "1 para Cuadrado\n" +
                "2 para Triángulo\n" +
                "3 para Círculo\n");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                if (opcion == 1 || opcion == 2 || opcion == 3)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("\nOpción no válida, intente nuevamente\n");
                }
            };
        }

        valido = false;
        while (valido == false)
        {
            if (opcion == 1) { Console.WriteLine("Ingrese la longitud del lado \n"); };
            if (opcion == 2) { Console.WriteLine("Ingrese la base \n"); };
            if (opcion == 3) { Console.WriteLine("Ingrese el radio \n"); };

            if (int.TryParse(Console.ReadLine(), out int x))
            {
                valido = true;
                X = x;
            }
            else
            {
                Console.WriteLine("\nNúmero no válido, intente nuevamente\n");
            }
        }

        if (opcion == 2)
        {
            valido = false;
            while (valido == false)
            {
                Console.WriteLine("Ingrese la altura \n");
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    valido = true;
                    Y = y;
                }
                else
                {
                    Console.WriteLine("\nNúmero no válido, intente nuevamente\n");
                }
            }
        }
        Console.WriteLine(CalculadoraDeArea.CalcularArea(opcion, X, Y));
    }
}