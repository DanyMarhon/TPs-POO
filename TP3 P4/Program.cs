using System.Text;

public class Producto
{
    private string codigoDeBarras { get; set; }
    private string? marca;
    private float precio;

    public string Marca
    {
        get { return marca!; }
        set { marca = value; }
    }
    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public Producto(string marca, string codBarra, float precio)
    {
        Marca = marca;
        codigoDeBarras = codBarra;
        Precio = precio;
    }

    public string MostrarProducto(Producto p)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(p.Marca.ToString());
        sb.AppendLine(p.Precio.ToString());
        return sb.ToString();
    }

    public static explicit operator string(Producto p)
    {
        return $"{p.codigoDeBarras.ToString()}";
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
        if (p1 is null || p2 is null) { return false; }
        else
        {
            return p1.Marca == p2.marca && p1.codigoDeBarras == p2.codigoDeBarras;
        }
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
        return (!(p1 == p2));
    }

    public static bool operator ==(Producto p1, string s)
    {
        return p1.Marca == s;
    }

    public static bool operator !=(Producto p1, string s)
    {
        return (!(p1 == s));
    }
}

public class Estante
{
    private Producto[] productos;
    private int ubicacionEstante;
    private int capacidad;

    public int Capacidad
    {
        get { return capacidad; }
        set { capacidad = value; }
    }

    public int UbicacionEstante
    {
        get { return ubicacionEstante; }
        set { ubicacionEstante = value; }
    }

    private Estante(int capacidad)
    {
        productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
        UbicacionEstante = ubicacion;
    }

    public object GetProductos()
    {
        return productos;
    }

    public static string MostrarEstante(Estante e1)
    {
        StringBuilder sb = new();
        foreach (var item in e1.productos)
        {
            if (item is not null)
            { sb.Append(item.MostrarProducto(item).ToString()); }
            else sb.Append("Lugar Vacio");
        }
        return sb.ToString();
    }

    public static bool operator ==(Estante e1, Producto p1)
    {
        bool resultado = false;
        foreach (var item in e1.productos)
        {
            if (item == p1) resultado = true;
        }
        return resultado;
    }

    public static bool operator !=(Estante e1, Producto p1)
    {
        bool resultado = true;
        foreach (var item in e1.productos)
        {
            if (item == p1) resultado = false;
        }
        return resultado;
    }

    public static bool operator +(Estante e1, Producto p1)
    {
        int primerLugarLibre = 0;
        bool lugarLibreDetectado = false;
        int cantidadOcupada = 0;
        int ultimoLugarLibre = 0;
        int contador = 0;
        foreach (var item in e1.productos)
        {
            contador++;
            if (item is not null) { cantidadOcupada++; 
                if (item == p1) { return false; } }
            if (item is null)
            {
                ultimoLugarLibre = contador - 1;
                if (lugarLibreDetectado == false)
                {
                    primerLugarLibre = ultimoLugarLibre;
                    lugarLibreDetectado = true;
                }
            }
        }
        if (e1.productos.Length > cantidadOcupada)
        {
            e1.productos[primerLugarLibre] = p1;
            return true;
        }
        return false;
    }

    public static bool operator -(Estante e1, Producto p1)
    {
        int cantidad = 0;
        bool resultado = false;
        foreach (var item in e1.productos)
        {
            cantidad++;
            if (item == p1) resultado = true;
            if (resultado == true)
            {
                e1.productos[cantidad - 1] = null;
                return true;
            }
        }
        return false;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);
            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752",
            (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine($"Agregó {0} {1} {2}", p1.Marca,
                (string)p1, p1.Precio);
            }
            else
            {
                Console.WriteLine($"¡NO agregó {0} {1} {2}!", p1.Marca,
                (string)p1, p1.Precio);
            }

            if (estante + p1)
            {
                Console.WriteLine($"Agregó {0} {1} {2}", p1.Marca,
                (string)p1, p1.Precio);
            }
            else
            {
                Console.WriteLine($"¡NO agregó {0} {1} {2}!", p1.Marca,
                (string)p1, p1.Precio);
            }

            if (estante + p2)
            {
                Console.WriteLine($"Agregó {0} {1} {2}", p2.Marca,
                (string)p2, p2.Precio);
            }
            else
            {
                Console.WriteLine($"¡NO agregó {0} {1} {2}!", p2.Marca,
                (string)p2, p2.Precio);
            }

            if (estante + p3)
            {
                Console.WriteLine($"Agregó {0} {1} {2}", p3.Marca,
                (string)p3, p3.Precio);
            }
            else
            {
                Console.WriteLine($"¡NO agregó {0} {1} {2}!", p3.Marca,
                (string)p3, p3.Precio);
            }

            if (estante + p4)
            {
                Console.WriteLine($"Agregó {0} {1} {2}", p4.Marca,
                (string)p4, p4.Precio);
            }
            else
            {
                Console.WriteLine($"¡NO agregó {0} {1} {2}!", p4.Marca,
                (string)p4, p4.Precio);
            }
            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.ReadLine();
        }
    }
}