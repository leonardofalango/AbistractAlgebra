public class Cos : Function
{
    private Function inner;
    public Cos(Function inner)
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