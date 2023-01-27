namespace ConsoleApp4
{
    internal interface IPair
    {
        double A { get; set; }
        double B { get; set; }

        IPair Add(IPair p);
        IPair Sub(IPair p);
        IPair Mult(IPair p);
        IPair Div(IPair p);
        bool Equ(IPair p);
        bool Great(IPair p);
        bool Less(IPair p);
        IPair Conj();

    }
}
