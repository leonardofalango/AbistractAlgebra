public class Mult : Function
{
    private List<Function> funcs = new List<Function>();
    public Mult Add(Function func)
    {
        funcs.Add(func);
        return this;
    }

    public override Function Derive()
    {
        Sum result = new Sum();
        foreach (Function f in funcs)
            result.Add(f.Derive());
        
        return result;
    }

    protected override double calculate(double x)
    {
        double result = 1;
        foreach (var item in funcs)
            result *= item[x];
        
        return result;
    }

}