namespace Gebrasharp;


public class Cotan : TrigFunction
{
    public Cotan(Function inner) : base(inner)
        => this.inner = inner;

    public override Function Derive()
    {
        Cosec cosec = new Cosec(inner);

        Mult mult = new Mult();
        mult.Add(cosec * cosec)
            .Add(inner);
        return mult;
    }

    protected override double calculate(double x)
        => 1 / (Math.Tan(x));
    
    public override string ToString()
        => $"ctg({inner})";
}