public static class Validador
{
    public static (bool, string) Validar(int valor, int min = -100, int max = 100)
    {
        bool validado = false;
        string mensaje = "Número no valido";

        if (valor >= min && valor <= max)
        {
            validado = true;
            mensaje = ("Número añadido a la lista");
        };

        return (validado, mensaje);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        List<int> list = new();

        Console.WriteLine("Ingrese 5 números de seguido");
        do
        {
            int numeroIngresado = 0;
            numeroIngresado = int.Parse(Console.ReadLine());
            while (Validador.Validar(numeroIngresado).Item1 == false)
            {
                Console.WriteLine(Validador.Validar(numeroIngresado).Item2);
                Console.WriteLine("Vuelva a ingresar el número dentro del rango -100 a 100");
                numeroIngresado = int.Parse(Console.ReadLine());
            }
            list.Add(numeroIngresado);
            Console.WriteLine(Validador.Validar(numeroIngresado).Item2.ToString());

            if (list.Count < 5) { Console.WriteLine("Ingrese el siguiente número"); };

        } while (list.Count < 5);

        Console.WriteLine("El promedio fué de " + list.Average().ToString());

        Console.WriteLine("El número máximo ingresado fué el " + list.Max(x => x).ToString());

        Console.WriteLine("El número mínimo ingresado fué el " + list.Min(x => x).ToString());
    }
}


// Ejemplo de ciclos
//var numero = 1;


//MIENTRAS
//while (numero < 5)
//HACER
//{
//    numero++;
//}

//HACER
//do
//{
//    numero++;
//HASTA
//} while (numero < 5);