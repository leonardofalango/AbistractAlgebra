namespace Gebrasharp;


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
        Sum sum = new Sum();

        for (int i = 0; i < funcs.Count; i++)
        {
            Mult mult = new Mult();
            for (int j = 0; i < funcs.Count; j++)
            {
                if (i == j)
                    mult.Add(funcs[i].Derive());
                else
                    mult.Add(funcs[i]);
            }
            sum.Add(mult);
        }

        return sum;
    }

    protected override double calculate(double x)
    {
        double result = 1;
        foreach (var item in funcs)
            result *= item[x];

        return result;
    }


    public override string ToString()
    {
        string str = string.Empty;

        foreach (var item in funcs)
        {
            str += item.ToString();
            str += " * ";
        }
        str = str.Substring(0, str.Length - 3);

        return str;
    }

    public static Mult operator *(Mult m, Function f)
        => m.Add(f);
    public static Mult operator *(Function f, Mult m)
        => m.Add(f);

}