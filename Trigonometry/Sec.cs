namespace Gebrasharp;


public class Sec : TrigFunction
{
    public Sec(Function inner) : base(inner)
        => this.inner = inner;

    public override Function Derive()
    {
        Tan tan = new Tan(inner);
        Sec sec = new Sec(inner);
        Mult mult1 = new Mult();
        mult1.Add(tan)
            .Add(sec);

        Mult mult = new Mult();
        mult.Add(mult1)
            .Add(inner);
        return mult;
    }

    protected override double calculate(double x)
        => 1 / (Math.Cos(x));

    public override string ToString()
        => $"sec({inner})";
}