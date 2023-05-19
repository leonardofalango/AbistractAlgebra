public class FunctionUtil
{
    private static Linear? linear = null;
    public static Function x 
    {
        get
        {
            if (linear == null)
                linear = new Linear();
            
            return linear;
        }
    }

    private static Constant? euler = null;
    public static Constant e
    {
        get
        {
            if (euler == null)
                euler = new Constant(Math.E);
            return euler;
        }
    }

    public static Sin sin(Function f)
    {
        Sin s = new Sin(f);
        return s;
    }

    public static Cos cos(Function f)
    {
        Cos cos = new Cos(f);
        return cos;
    }

    public static Constant pi()
        => new Constant(Math.PI);
    
}

public static class NumberToConstant
{
    // ToConstant Functions
    public static Constant ToConstant(this double num)
        => new Constant(num);
    public static Constant ToConstant(this int num)
        => new Constant(num);
    public static Constant ToConstant(this float num)
        => new Constant(num);
}