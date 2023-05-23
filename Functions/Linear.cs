namespace Gebrasharp;


public class Linear : Function
{
    public override Function Derive()
        => new Constant(1);
    protected override double calculate(double x)
        => x;
    
    public override string ToString()
        => $"x";
}