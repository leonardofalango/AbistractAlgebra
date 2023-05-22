public class Div : Function
{
    private List<Function> funcs = new List<Function>();
    public Div Add(Function func)
    {
        funcs.Add(func);
        return this;
    }

    // TODO - Derive Function
    public override Function Derive()
    {
        throw new NotImplementedException();
    }

    protected override double calculate(double x)
    {
        double result = funcs[0][x];
        for (int i = 1; i < funcs.Count; i++)
            result /= funcs[i][x];

        return result;
    }


    public override string ToString()
    {
        string str = string.Empty;

        foreach (var item in funcs)
        {
            str += item.ToString();
            str += " / ";
        }
        str = str.Substring(0, str.Length - 3);

        return str;
    }

    public static Div operator /(Div d, Function f)
        => d.Add(f);
    public static Div operator /(Function f, Div d)
        => d.Add(f);

}