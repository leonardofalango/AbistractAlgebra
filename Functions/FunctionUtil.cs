namespace Gebrasharp;


public class FunctionUtil
{
    public static Sin sin(Function f)
        => new Sin(f);

    public static Cos cos(Function f)
        => new Cos(f);

    public static Tan tg(Function f)
        => new Tan(f);

    public static Log logE(Function f)
        => new Log(f, e);

    public static Log log(Function f)
        => new Log(f, 10.ToConstant());


    // -------------------------------------------------------------------------------
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
    private static Constant? math_pi;
    public static Constant pi
    {
        get
        {
            if (math_pi == null)
                math_pi = new Constant(Math.PI);
            return math_pi;
        }
    }

}

public static class NumberTo
{
    // ToConstant Functions
    public static Constant ToConstant(this double num)
        => new Constant(num);
    public static Constant ToConstant(this int num)
        => new Constant(num);
    public static Constant ToConstant(this float num)
        => new Constant(num);
    
    // ToRadian Functions
    public static double ToRadian(this double num)
        => num * (180 / Math.PI);
    public static double ToRadian(this int num)
        => num * (180 / Math.PI);
    public static double ToRadian(this float num)
        => num * (180 / Math.PI);
    
    // ToRadianConstant
    public static Constant ToRadianConstant(this double num)
        => new Constant(num * (180 / Math.PI));
    public static Constant ToRadianConstant(this int num)
        => new Constant(num * (180 / Math.PI));
    public static Constant ToRadianConstant(this float num)
        => new Constant(num * (180 / Math.PI));

}