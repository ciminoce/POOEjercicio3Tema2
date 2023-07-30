namespace POOEjercicio3Tema2.Entidades
{
    public class Yarda
    {
        private double _distancia;
        public static readonly double _equivalenciaConKilometro;
        static Yarda()
        {
            _equivalenciaConKilometro = 1093.61;
        }

        public double GetDistancia() => _distancia;
        public Yarda(double distancia)
        {
            if (distancia <= 0)
            {
                throw new ArgumentException("Distancia no válida");
            }

            _distancia = distancia;
        }
        public Yarda() : this(100) { }
        public static implicit operator double(Yarda yarda)
        {
            return yarda.GetDistancia();
        }

        public static bool operator ==(Yarda y1, Yarda y2)
        {
            return y1.GetDistancia() == y2.GetDistancia();
        }

        public static bool operator !=(Yarda y1, Yarda y2)
        {
            return !(y1 == y2);
        }
        public static Yarda operator +(Yarda y1, Yarda y2)
        {
            return new Yarda(y1.GetDistancia() + y2.GetDistancia());
        }
        public static Yarda operator -(Yarda y1, Yarda y2)
        {
            if (y2.GetDistancia() > y1.GetDistancia())
            {
                throw new Exception("El resultado arroja un negativo");
            }
            return new Yarda(y1.GetDistancia() - y2.GetDistancia());
        }

        public static Yarda operator +(Yarda y1, Kilometro k1)
        {
            return y1+(Yarda)k1;
        }
        public static Yarda operator +(Yarda y1, Milla m1)
        {
            return y1 + (Yarda)m1;
        }

        public static Yarda operator -(Yarda y1, Kilometro k1)
        {
            return y1- (Yarda)k1;
        }
        public static Yarda operator -(Yarda y1, Milla m1)
        {
            return y1- (Yarda)m1;
        }




        public static explicit operator Kilometro(Yarda yarda)
        {
            return new Kilometro(yarda.GetDistancia() / Yarda._equivalenciaConKilometro);
        }
        public static explicit operator Milla(Yarda yarda)
        {
            return new Milla((Kilometro)yarda * Milla._equivalenciaConKilometro);
        }

    }
}
