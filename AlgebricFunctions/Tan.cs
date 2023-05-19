public class Tan : Function
{
    private Function inner;
    public Tan(Function inner)
        => this.inner = inner;
    public override Function Derive()
    {
        throw new NotImplementedException();
    }

    protected override double calculate(double x)
        => Math.Tan(inner[x]);

    public override string ToString()
        => $"tg({inner})";
}