using System.Text;

namespace Entidades
{
    public class Jugador
    {
        private int Dni { get; set; }
        private string Nombre { get; set; }
        private int PartidosJugados { get; set; }
        private double PromedioGoles { get; set; }
        private int TotalGoles { get; set; }

        public Jugador(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
            TotalGoles = 0;
            PartidosJugados = 20;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados)
        {
            Dni = dni;
            Nombre = nombre;
            TotalGoles = totalGoles;
            PartidosJugados = partidosJugados;
        }

        public double GetPromedioGoles()
        {
            PromedioGoles = TotalGoles / PartidosJugados;
            return PromedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new ();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Total Goles: {TotalGoles}");
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");
            sb.AppendLine($"Promedio de goles: {GetPromedioGoles()}");
            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is Jugador jugador &&
                   Dni == jugador.Dni;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Dni);
        }

        public static bool operator ==(Jugador? left, Jugador? right)
        {
            if (left is null || right is null) return false; ;
            if (left!.Dni == right!.Dni) { return true; }
            else { return false; }
        }

        public static bool operator !=(Jugador? left, Jugador? right)
        {
            return !(left == right);
        }
    }
}
