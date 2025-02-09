namespace ClassLibraryTP4P1
{
    public class Termino
    {
        private int _numero { get; }
        private int? _posicion;

        public Termino(int numero, int? posicion)
        {
            _numero = numero;
            Posicion = posicion ?? 0;
        }

        public Termino(int numero)
        {
            _numero = numero;
            Posicion = 0;
        }

        public int? Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

        public string InformarTermino()
        {
            return $"Número {_numero} Posición {_posicion}";
        }

        public static bool operator ==(Termino t1, Termino t2)
        {
            bool resultado = false;
            if (t1._numero == t2._numero) resultado = true;
            return resultado;
        }

        public static bool operator !=(Termino t1, Termino t2)
        {
            return !(t1 == t2);
        }

        public static Termino operator +(Termino t1, Termino t2)
        {
            int valor = (t1._numero + t2._numero);
            Termino t = new Termino(valor);
            return t;
        }

        public string ToString(Termino t1)
        {
            return t1._numero.ToString();
        }
    }
}
