using System.Text;

public static class Multiplicador
{
    public static string Multiplicar(int numero, int? limite)
    {
        StringBuilder sb = new StringBuilder();
        int multi = 1;
        if (limite == null) { limite = 10; }
        do
        {
            sb.AppendLine($"{numero} X {multi} = {numero * multi}");
            multi++;
        }
        while (multi <= limite);
        return sb.ToString();
    }
}


public class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        int? limite = null;
        bool valido = false;
        while (valido == false)
        {
            Console.WriteLine("Ingrese el número a multiplicar\n");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                valido = true;
                numero = x;
            }
            else
            {
                Console.WriteLine("\nNúmero no válido, intente nuevamente\n");
            }
        }

        Console.WriteLine("Desea ingresar un límite?\n Presione Y para confirmar");
        var respuesta = Console.ReadLine().ToUpper();
        if (respuesta == "Y")
        {
            limite = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"La tabla de multiplicar del {numero} es:");
        Console.WriteLine($"{Multiplicador.Multiplicar(numero, limite)}");
    }
}