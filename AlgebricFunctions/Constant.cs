public class Constant : Function
{
    public override Function Derive()
        => new Constant(0);

    private double result;
    public Constant(double value)
        => this.result = value;
    
    protected override double calculate(double x)
        => result;
}