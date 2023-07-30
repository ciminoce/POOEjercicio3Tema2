namespace POOEjercicio3Tema2.Entidades
{
    public class Kilometro
    {
        private double _distancia;

        public double GetDistancia() => _distancia;
        public Kilometro(double distancia)
        {
            if (distancia <= 0)
            {
                throw new ArgumentException("Distancia no válida");
            }

            _distancia = distancia;
        }
        public Kilometro() : this(100) { }

        public static implicit operator double(Kilometro kilometro)
        {
            return kilometro.GetDistancia();
        }

        public static bool operator ==(Kilometro k1, Kilometro k2 )
        {
            return k1.GetDistancia() == k2.GetDistancia();
        }

        public static bool operator !=(Kilometro k1 , Kilometro k2 )
        {
            return !(k1 == k2);
        }

        public static Kilometro operator+(Kilometro k1, Kilometro k2)
        {
            return new Kilometro(k1.GetDistancia()+k2.GetDistancia());
        }
        public static Kilometro operator-(Kilometro k1, Kilometro k2)
        {
            return new Kilometro(k1.GetDistancia() - k2.GetDistancia());
        }

        public static Kilometro operator+(Kilometro k1, Milla m1)
        {
            return k1+(Kilometro)m1;
        }
        public static Kilometro operator+(Kilometro k1, Yarda y1)
        {
            return k1+(Kilometro)y1;
        }

        public static Kilometro operator -(Kilometro k1, Milla m1)
        {
            return k1-(Kilometro)m1;
        }
        public static Kilometro operator -(Kilometro k1, Yarda y1)
        {
            return k1-(Kilometro)y1;
        }



        public static explicit operator Yarda(Kilometro k1)
        {
            return new Yarda(k1.GetDistancia() * Yarda._equivalenciaConKilometro);
        }
        public static explicit operator Milla(Kilometro k1)
        {
            return new Milla(k1.GetDistancia() * Milla._equivalenciaConKilometro);
        }
    }
}