namespace Gebrasharp;


public abstract class TrigFunction : Function
{
    protected Function inner;
    public TrigFunction(Function inner)
        => this.inner = inner;
}