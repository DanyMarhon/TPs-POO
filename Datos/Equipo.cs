using Entidades;
using System.Text;

namespace Datos
{
    public class Equipo
    {
        private int CantidadJugadores { get; set; }
        private List<Jugador> ListaJugadores = new List<Jugador>();
        private string Nombre { get; set; }

        public Equipo(int cantidadJugadores, string nombre)
        {
            CantidadJugadores = cantidadJugadores;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }

        public int GetCantidadJugadores()
        {
            return CantidadJugadores;
        }

        public override bool Equals(object? obj)
        {
            return obj is Equipo equipo &&
                   Nombre == equipo.Nombre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CantidadJugadores, ListaJugadores, Nombre);
        }

        public static bool operator ==(Equipo? left, Equipo? right)
        {
            if (left is null || right is null) return false; ;
            if (left!.Nombre == right!.Nombre) { return true; }
            else { return false; }
        }

        public static bool operator !=(Equipo? left, Equipo? right)
        {
            return !(left == right);
        }

        public static Equipo operator +(Equipo? e, Jugador? j)
        {
            if (j is null || e is null) throw new ArgumentNullException("Equipo o jugador no pueden ser null.");
            if (e.ListaJugadores.Contains(j)) throw new InvalidOperationException("El jugador ya está en el equipo.");
            if (e.ListaJugadores.Count >= e.CantidadJugadores) throw new InvalidOperationException("No se pueden agregar más jugadores al equipo.");
            else
            {
                e.ListaJugadores.Add(j);
                return e;
            }
        }

        public string MostrarDatosEquipo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del equipo: {Nombre}");
            sb.AppendLine($"Cantidad limite de jugadores: {CantidadJugadores} \n");
            sb.AppendLine($"Lista de jugadores: \n");
            if (ListaJugadores.Count >= 1) 
            {
                foreach (var jugador in ListaJugadores)
                {
                    sb.AppendLine($"{jugador.MostrarDatos()}");
                }
            }
            else { sb.AppendLine($"Lista de jugadores vacia \n"); };
            
            sb.AppendLine($"-----------------------");
            return sb.ToString();
        }

        public static implicit operator string(Equipo e)
        {
            return e.MostrarDatosEquipo();
        }
    }
}
