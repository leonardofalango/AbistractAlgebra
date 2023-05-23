namespace Gebrasharp;


public class Cos : TrigFunction
{
    public Cos(Function inner) : base(inner)
        => this.inner = inner;
    public override Function Derive()
    {
        Sin c = new Sin(inner);
        Mult m = new Mult();
        m.Add(-c).Add(inner);
        return m;
    }

    protected override double calculate(double x)
        => Math.Cos(inner[x]);

    public override string ToString()
        => $"cos({inner})";
}