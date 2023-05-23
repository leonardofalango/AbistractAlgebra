namespace Gebrasharp;


public class Sin : TrigFunction
{
    public Sin(Function inner) : base(inner)
        => this.inner = inner;
    public override Function Derive()
    {
        Cos c = new Cos(inner);
        Mult m = new Mult();
        m.Add(c).Add(inner);
        return m;
    }

    protected override double calculate(double x)
        => Math.Sin(inner[x]);

    public override string ToString()
        => $"sin({inner})";
}