public static class Conversor
{
    public static string DecimalABinario(string valor)
    {
        string mensaje = "Número no valido";

        if (int.TryParse(valor, out int X))
        {
            string binario = Convert.ToString(X, 2);
            mensaje = ($"Número equivale a {binario} en binario");
        };

        return mensaje;
    }

    public static string BinarioADecimal(string valor)
    {
        string mensaje = "Número no valido";

        if (int.TryParse(valor, out int X))
        {
            int ndecimal = Convert.ToInt32(valor, 2);
            mensaje = ($"Número equivale a {ndecimal} en decimal");
        };

        return mensaje;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 1 para convertir Decimal a Binario \n" +
            "Ingrese 2 para convertir Binario a Decimal \n");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.WriteLine("Ingrese el número para convertir de Decimal a Binario");
            Console.WriteLine(Conversor.DecimalABinario(Console.ReadLine()).ToString());
        }

        if (opcion == "2")
        {
            Console.WriteLine("Ingrese el número para convertir de Binario a Decimal");
            Console.WriteLine(Conversor.BinarioADecimal(Console.ReadLine()).ToString());
        }
    }
}