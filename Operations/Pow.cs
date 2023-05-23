namespace Gebrasharp;


public class Pow : Function
{
    Function inner;
    Function pot;
    public Pow(Function inner, Function pot)
    {
        this.inner = inner;
        this.pot = pot;
    }

    // TODO - Derive Function
    public override Function Derive()
    {
        throw new NotImplementedException();
    }

    protected override double calculate(double x)
        => Math.Pow(inner[x], pot[x]);


    public override string ToString()
        => $"{inner} ^ {pot}";
}