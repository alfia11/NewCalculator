namespace calculator
{
    public class Oper
    {
        public double Add(double n, double m)
        {
            double x = n + m;
            return x;
        }
        public double Sub(double n, double m)
        {
            double x = n - m;
            return x;
        }
        public double Mul(double n, double m)
        {
            double x = n * m;
            return x;
        }
        public double Div(double n, double m)
        {
            double x = n / m;
            return x;
        }
        public double Percen(double n, double m)
        {
            double x = (n / 100) * m;
            return x;
        }
        

    }
}
