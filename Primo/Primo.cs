namespace Entidades
{
    public class Primo
    {
        public int? Numero { get; set; }

        public Primo(int? numero)
        {
            Numero = numero;
        }

        public static bool operator ==(Primo p1, Primo p2)
        {
            bool resultado = false;
                if (p2.Numero == p1.Numero) resultado = true;;
            return resultado;
        }

        public static bool operator !=(Primo p1, Primo p2)
        {
            bool resultado = true;
            if (p2.Numero == p1.Numero) resultado = true; ;
            return resultado;
        }
        public static bool EsPrimo(int? n)
        {
            if (n < 2)
                return false;
            if (n == 2 || n == 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            return true;
        }
    }
}

