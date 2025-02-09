using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class RepoPrimos
    {
        private int _cantidad;
        public Primo[]? primos;
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public RepoPrimos(int cantidad)
        {
            _cantidad = cantidad;
            primos = new Primo[_cantidad];
        }

        public RepoPrimos()
        {
            _cantidad = 5;
            primos = new Primo[_cantidad];
        }

        public static bool operator +(RepoPrimos r1, Primo p1)
        {
            int primerLugarLibre = 0;
            bool lugarLibreDetectado = false;
            int cantidadOcupada = 0;
            int ultimoLugarLibre = 0;
            int contador = 0;
            foreach (var item in r1.primos)
            {
                contador++;
                if (item is not null)
                {
                    cantidadOcupada++;
                    if (item.Numero == p1.Numero) { return false; }
                }
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
            if (r1.primos.Length > cantidadOcupada)
            {
                r1.primos[primerLugarLibre] = p1;
                return true;
            }
            return false;
        }

        public static bool operator -(RepoPrimos r1, Primo p1)
        {
            int cantidad = 0;
            bool resultado = false;
            foreach (var item in r1.primos)
            {
                cantidad++;
                if (item == p1) resultado = true;
                if (resultado == true)
                {
                    r1.primos[cantidad - 1] = null;
                    return true;
                }
            }
            return false;
        }
        public static bool operator ==(RepoPrimos r1, Primo p1)
        {
            bool resultado = false;
            foreach (var item in r1.primos)
            {
                if (item == p1) resultado = true;
            };
            return resultado;
        }

        public static bool operator !=(RepoPrimos r1, Primo p1)
        {
            bool resultado = true;
            foreach (var item in r1.primos)
            {
                if (item == p1) resultado = false;
            };
            return resultado;
        }
        public string MostrarNumeros(RepoPrimos r1)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in r1.primos)
            {
                if (item is null || !Primo.EsPrimo(item.Numero)) sb.AppendLine("Null");
                else { sb.AppendLine($"{item.Numero.ToString()}"); };
            };
            return sb.ToString();
        }
        public string VerificarNumero (RepoPrimos r1, Primo numero)
        {
            StringBuilder sb = new StringBuilder();
            int posicion = 0;
            bool resultado = false;
            foreach (var item in r1.primos)
            {
                posicion++;
                if (item == numero) resultado = true;
                if (resultado == true) 
                { sb.AppendLine($"El número {numero.Numero.ToString()} se encuentra en el repo en la posición {posicion.ToString()}."); };
            };
            if (resultado == false)
            { sb.AppendLine($"El número {numero.Numero.ToString()} no se encuentra en el repo."); };
            return sb.ToString();
        }

        public void OrdenarArrayASC(RepoPrimos r1)
        {
            Array.Sort(r1.primos); // Ordena el array en orden ascendente
        }

        public void OrdenarArrayDSC(RepoPrimos r1)
        {
            Array.Reverse(r1.primos); // Ordena el array en orden ascendente
        }

        public static implicit operator int (RepoPrimos r1)
        {
            int valor = 0;
            bool resultado = false;
            foreach (var item in r1.primos)
            {
                if (item is Primo && item.Numero is not null) { valor += (int)item.Numero; };
            }
            return valor;
        }
    }
}
