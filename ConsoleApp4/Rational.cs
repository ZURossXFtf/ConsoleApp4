namespace ConsoleApp4
{
    internal class Rational : IPair

    {
        public double A { get; set; }
        public double B { get; set; }
        public Rational(double a, double b)
        {
            A = a;
            B = b;
        }

        public IPair Add(IPair p)
        {
            return new Rational(this.A * p.B + p.A * this.B, p.A * p.B);
        }

        public IPair Sub(IPair p)
        {
            return new Rational(this.A * p.B - p.A * this.B, p.A * p.B);
        }
        public IPair Mult(IPair p)
        {
            return new Rational(this.A * this.B, p.A * p.B);
        }

        public IPair Div(IPair p)
        {
            return new Rational(this.A * p.B, p.A * this.B);
        }
        public bool Equ(IPair p)
        {
            return (this.A == this.B) && (p.A == p.B);
        }
        public bool Great(IPair p)
        {
            return (this.A >= this.B) && (p.A >= p.B);
        }
        public bool Less(IPair p)
        {
            return (this.A <= this.B) && (p.A <= p.B);
        }


        public IPair Conj()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }


    }
}
