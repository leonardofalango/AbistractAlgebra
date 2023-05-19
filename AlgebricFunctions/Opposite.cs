public class Opposite : Function
{
    private Function func;
    public Opposite(Function func)
    {
        this.func = func;
    }
    public override Function Derive()
    {
        throw new NotImplementedException();
    }

    protected override double calculate(double x)
        => -func[x];

    public override string ToString()
        => $"-({func})";
}