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

    public static Function sin(Function f)
    {
        Sin s = new Sin(f);
        return s;
    }

    public static Cos cos(Function f)
    {
        Cos cos = new Cos(f);
        return cos;
    }
}