namespace Gebrasharp;


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


    public override string ToString()
    {
        string str = string.Empty;

        foreach (var item in funcs)
        {
            str += item.ToString();
            str += " + ";
        }
        str = str.Substring(0, str.Length - 3);

        return str;
    }

    public static Sum operator +(Sum s, Function f)
        => s.Add(f);
    public static Sum operator +(Function f, Sum s)
        => s.Add(f);

}