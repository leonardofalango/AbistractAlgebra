namespace Gebrasharp;


public class Tan : TrigFunction
{
    public Tan(Function inner) : base(inner)
        => this.inner = inner;

    // TODO - Derive Function
    public override Function Derive()
    {
        Sec sec = new Sec(inner);
        Mult m = new Mult();
        m.Add(sec * sec).Add(inner);
        return m;
    }

    protected override double calculate(double x)
        => Math.Tan(inner[x]);

    public override string ToString()
        => $"tg({inner})";
}