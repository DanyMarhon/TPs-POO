using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el año, luego el número de mes, luego el número de día");
        var anio = int.Parse(Console.ReadLine());
        var mes = int.Parse(Console.ReadLine());
        var dia = int.Parse(Console.ReadLine());

        DateTime fechaIngresada = new DateTime(anio, mes, dia);

        Console.WriteLine($"{fechaIngresada.ToShortDateString()}");

        Console.WriteLine($"Desea agregar días a la fecha? \n Y / N");
        string respuesta = Console.ReadLine();

        if (respuesta == "Y")
        {
            Console.WriteLine("Ingrese la cantidad de días a sumar");
            var dias = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(fechaIngresada.AddDays(dias)).ToShortDateString()}");
        }

        //Console.Write(fechaIngresada.Day);
        //if (fechaIngresada.Month == 2) { Console.Write(" Febrero "); };
        //Console.Write(fechaIngresada.Year);

        Console.WriteLine($"Desea comparar la fecha? \n Y / N");
        respuesta = Console.ReadLine();

        if (respuesta == "Y")
        {
            Console.WriteLine("Ingrese el año, luego el número de mes, luego el número de día");
            anio = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            dia = int.Parse(Console.ReadLine());

            DateTime fechaIngresada2 = new DateTime(anio, mes, dia);

            if (fechaIngresada == fechaIngresada2) { Console.WriteLine("Las fechas son iguales"); }
            else if (fechaIngresada < fechaIngresada2) { Console.WriteLine($"La fecha {fechaIngresada.ToShortDateString()} es anterior"); }
            else Console.WriteLine($"La fecha {fechaIngresada2.ToShortDateString()} es anterior");
        }

        Console.WriteLine($"Desea calcular una edad? \n Y / N");
        respuesta = Console.ReadLine();

        if (respuesta == "Y")
        {
            Console.WriteLine("Ingrese el año, luego el número de mes, luego el número de día");
            anio = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            dia = int.Parse(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(anio, mes, dia);

            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (DateTime.Now.Month < fechaNacimiento.Month ||
                (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            Console.WriteLine($"La edad del usuario es {edad.ToString()}");
        }
    }
}