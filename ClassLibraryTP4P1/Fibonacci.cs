using System.ComponentModel.DataAnnotations;

namespace ClassLibraryTP4P1
{
    public class Fibonacci
    {
        private int _cantidadTerminos { get; }
        private int? _tope;
        private Termino[] terminos;

        public int? CantidadTerminos
        {
            get { return _cantidadTerminos; }
        }
        public Fibonacci(int cantidadTerminos, int? tope)
        {
            if (cantidadTerminos > 0 && cantidadTerminos <= 20)
            {
                _cantidadTerminos = cantidadTerminos;
            }
            else { _cantidadTerminos = 5; }
            Tope = tope ?? 0;
            terminos = new Termino[_cantidadTerminos];
        }

        public Fibonacci()
        {
            _cantidadTerminos = 5;
            terminos = new Termino[_cantidadTerminos];
        }

        public int? Tope
        {
            get { return _tope; }
            set { _tope = value; }
        }

        internal bool EstaLleno(Fibonacci f1)
        {
            int cantidad = f1.terminos.Count();
            if (cantidad == f1._cantidadTerminos) { return true; } else { return false; }
        }
        internal bool EstaVacio(Fibonacci f1)
        {
            int cantidad = f1.terminos.Count();
            if (cantidad == 0) { return true; } else { return false; }
        }

        public static bool operator +(Fibonacci f1, Termino t1)
        {
            int primerLugarLibre = 0;
            bool lugarLibreDetectado = false;
            int cantidadOcupada = 0;
            int ultimoLugarLibre = 0;
            int contador = 0;
            foreach (var item in f1.terminos)
            {
                contador++;
                if (item is not null)
                {
                    cantidadOcupada++;
                    if (item == t1) { return false; }
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
            if (f1.terminos.Length > cantidadOcupada)
            {
                f1.terminos[primerLugarLibre] = t1;
                return true;
            }
            return false;
        }
        public static bool operator ==(Fibonacci f1, Termino t1)
        {
            bool resultado = false;
            foreach (var item in f1.terminos)
            {
                if (item == t1) resultado = true;
            };
            return resultado;
        }

        public static bool operator !=(Fibonacci f1, Termino t1)
        {
            bool resultado = true;
            foreach (var item in f1.terminos)
            {
                if (item == t1) resultado = false;
            };
            return resultado;
        }

        public void GenerarTerminos()
        {

        }
    }
}
