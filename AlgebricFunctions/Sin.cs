public class Sin : Function
{
    private Function inner;
    public Sin(Function inner)
        => this.inner = inner;
    public override Function Derive()
    {
        throw new NotImplementedException();
    }

    protected override double calculate(double x)
        => Math.Sin(inner[x]);


}