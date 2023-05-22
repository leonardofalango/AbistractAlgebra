public class Sub : Function
{
    private List<Function> funcs = new List<Function>();
    public Sub Add(Function func)
    {
        funcs.Add(func);
        return this;
    }

    public override Function Derive()
    {
        Sub result = new Sub();
        foreach (Function f in funcs)
            result.Add(f.Derive());

        return result;
    }

    protected override double calculate(double x)
    {
        double result = funcs[0][x];
        for (int i = 1; i < funcs.Count; i++)
        {
            result -= funcs[i][x];
        }
        return result;
    }


    public override string ToString()
    {
        string str = string.Empty;

        foreach (var item in funcs)
        {
            str += item.ToString();
            str += " - ";
        }
        str = str.Substring(0, str.Length - 3);

        return str;
    }

    public static Sub operator +(Sub s, Function f)
        => s.Add(f);
    public static Sub operator +(Function f, Sub s)
        => s.Add(f);

}