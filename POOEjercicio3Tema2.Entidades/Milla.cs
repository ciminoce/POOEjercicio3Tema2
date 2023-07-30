namespace POOEjercicio3Tema2.Entidades
{
    public class Milla
    {
        private double _distancia;
        public static readonly double _equivalenciaConKilometro;
        static Milla()
        {
            _equivalenciaConKilometro = 0.621371;
        }

        public double GetDistancia() => _distancia;
        public Milla(double distancia)
        {
            if (distancia<=0)
            {
                throw new ArgumentException("Distancia no válida");
            }
            _distancia = distancia;
        }
        public Milla() : this(100) { }
        public static implicit operator double(Milla milla)
        {
            return milla.GetDistancia();
        }

        public static bool operator ==(Milla m1, Milla m2)
        {
            return m1.GetDistancia() == m2.GetDistancia();
        }

        public static bool operator !=(Milla m1, Milla m2)
        {
            return !(m1==m2);
        }
        public static Milla operator +(Milla m1, Milla m2)
        {
            return new Milla(m1.GetDistancia() +m2.GetDistancia());
        }
        public static Milla operator -(Milla m1, Milla m2)
        {
            
            return new Milla(m1.GetDistancia() - m2.GetDistancia());
        }

        public static Milla operator +(Milla m1, Kilometro k1)
        {
            return m1+(Milla)k1;
        }
        public static Milla operator +(Milla m1, Yarda y1)
        {
            return m1 + (Milla)y1;
        }

        public static Milla operator -(Milla m1, Kilometro k1)
        {
            return m1 - (Milla)k1;
        }
        public static Milla operator -(Milla m1, Yarda y1)
        {
            return m1- (Milla)y1;
        }


        public static explicit operator Kilometro(Milla milla)
        {
            return new Kilometro(milla.GetDistancia() / Milla._equivalenciaConKilometro);
        }
        public static explicit operator Yarda(Milla milla)
        {
            return new Yarda((Kilometro)milla * Yarda._equivalenciaConKilometro);
        }

    }
}
