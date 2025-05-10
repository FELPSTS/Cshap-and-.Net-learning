namespace staticmethod
{
    class Calculadora
    {    
        public double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2.0 * Math.PI * r;
        }
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
        }
    }
}