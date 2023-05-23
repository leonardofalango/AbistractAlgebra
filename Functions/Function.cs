// Componente base da estrutura, representa uma função qualquer
namespace Gebrasharp;


public abstract class Function
{
    // Permite usar y = f[10]
    public double this[double x] // Func[x] { return calculate(x)}
        => calculate(x);
    protected abstract double calculate(double x);
    // Bônus para quem sabe derivar
    public abstract Function Derive();

    public static Function operator +(Function f, Function g)
    {
        Sum s = new Sum();
        s.Add(f).Add(g);
        return s;
    }

    public static Function operator +(Function f, double g)
    {
        Sum s = new Sum();
        s.Add(f).Add(new Constant(g));
        return s;
    }

    public static Function operator +(double g, Function f)
    {
        Sum s = new Sum();
        s.Add(f).Add(new Constant(g));
        return s;
    }

    public static Function operator *(Function f, Function g)
    {
        Mult s = new Mult();
        s.Add(f).Add(g);
        return s;
    }

    public static Function operator ^(Function f, Function g)
        => new Pow(f, g);

    public static Function operator /(Function f, Function g)
    {
        Div d = new Div();
        d.Add(f).Add(g);
        return d;
    }

    public static Function operator -(Function f, Function g)
    {
        Sub d = new Sub();
        d.Add(f).Add(g);
        return d;
    }

    public static Function operator -(Function f)
        => new Opposite(f);

}