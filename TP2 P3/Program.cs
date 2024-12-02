public static class Calculadora
{
    private static bool Validar(double n2)
    {
        if (n2 != 0)
        {
            return true;
        }
        else { return false; }
    }
    public static string Calcular(double n1, double n2, string Operacion)
    {
        string mensaje = string.Empty;
        switch (Operacion)
        {
            case "*":
                {
                    mensaje = $"\nResultado de la multiplicación es: {n1 * n2}";
                    return mensaje;
                }
            case "/":
                {
                    if (!(Validar(n2)))
                    {
                        mensaje = "\nNo se puede dividir por cero";
                        return mensaje;
                    }
                    mensaje = $"\nResultado de la división es: {n1 / n2}";
                    return mensaje;
                }
            case "+":
                {
                    mensaje = $"\nResultado de la suma es: {n1 + n2}";
                    return mensaje;
                }
            case "-":
                {
                    mensaje = $"\nResultado de la resta es: {n1 - n2}";
                    return mensaje;
                }
            default:
                {
                    mensaje = "\nOperación inválida";
                    return mensaje;
                }
        }
    }
}



public class Program
{
    static void Main(string[] args)
    {
        double n1 = 0;
        double n2 = 0;
        string operacion = string.Empty;

        bool valido = false;
        while (valido == false)
        {
            Console.WriteLine("Ingrese el primer operando \n");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                valido = true;
                n1 = x;
            }
            else
            {
                Console.WriteLine("Número no válido, intente nuevamente \n");
            }
        }

        valido = false;
        while (valido == false)
        {
            Console.WriteLine("Ingrese el segundo operando \n");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                valido = true;
                n2 = x;
            }
            else
            {
                Console.WriteLine("Número no válido, intente nuevamente \n");
            }
        }

        valido = false;
        while (valido == false)
        {
            Console.WriteLine("Ingrese el tipo de Operación: \n" +
            "Para multiplicar presione * \n" +
            "Para sumar presione + \n" +
            "Para restar presione - \n" +
            "Para dividir presione / \n");

            string input = Console.ReadLine();

            if (input == "+" || input == "/" || input == "*" || input == "-")
            {
                valido = true;
                operacion = input;
            }
            else
            {
                Console.WriteLine("Operación no válida, intente nuevamente \n");
            }
        }

        Console.WriteLine(Calculadora.Calcular(n1, n2, operacion));
    }
}