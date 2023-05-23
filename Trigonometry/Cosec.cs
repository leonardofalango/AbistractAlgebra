namespace Gebrasharp;


public class Cosec : TrigFunction
{
    public Cosec(Function inner) : base(inner)
        => this.inner = inner;

    public override Function Derive()
    {
        Cotan cotg = new Cotan(inner);
        Cosec cosec = new Cosec(inner);
        Mult mult1 = new Mult();
        mult1.Add(cotg)
            .Add(cosec);

        Mult mult = new Mult();
        mult.Add(mult1)
            .Add(inner);
        return mult;
    }

    protected override double calculate(double x)
        => 1 / (Math.Sin(x));

    public override string ToString()
        => $"csc({inner})";
}