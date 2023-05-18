public class Sum : Function
{
    private List<Function> funcs = new List<Function>();
    public Sum Add(Function func)
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
        => funcs.Sum(e => e[x]);
}