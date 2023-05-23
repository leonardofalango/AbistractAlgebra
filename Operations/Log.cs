namespace Gebrasharp;


public class Log : Function
{
    private Function inner;
    private Function logBase;
    public Log(Function inner, Function logBase)
    {
        this.inner = inner;
        this.logBase = logBase;
    }

    // TODO - Derive Function
    public override Function Derive()
    {
        throw new NotImplementedException();
    }

    protected override double calculate(double x)
        => Math.Log(inner[x], logBase[x]);


    public override string ToString()
        => $"log(x)";
}