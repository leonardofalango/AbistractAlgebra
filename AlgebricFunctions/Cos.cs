public class Cos : Function
{
    private Function inner;
    public Cos(Function inner)
        => this.inner = inner;
    public override Function Derive()
    {
        throw new NotImplementedException();
    }

    protected override double calculate(double x)
        => Math.Cos(inner[x]);

    public override string ToString()
        => $"cos({inner})";
}